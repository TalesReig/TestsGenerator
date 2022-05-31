using FluentValidation.Results;
using TestsGenerator.Domain.MateriaModule;
using TestsGenerator.Infra.Database.DisciplineModule;
using TestsGenerator.Infra.Database.MateriaModule;
using TestsGenerator.Shared;

namespace TestsGenerator.MateriaModule
{
    public class MateriaController : BaseController
    {
        private readonly MateriaRepository _materiaRepository;
        private readonly DisciplineRepository _disciplineRepository;

        private readonly MateriaControl materiaControl;

        public MateriaController(MateriaRepository materiaRepository, DisciplineRepository disciplineRepository)
        {
            _materiaRepository = materiaRepository;
            _disciplineRepository = disciplineRepository;
            materiaControl = new(this);
        }

        public override void Insert()
        {
            RegisterMateriaForm screen = new(_disciplineRepository)
            {
                Materia = new(),
                SaveRecord = _materiaRepository.Insert
            };

            DialogResult dialogResult = screen.ShowDialog();

            if (dialogResult == DialogResult.OK) 
                LoadMaterias();
        }

        public override void Update()
        {
            Materia? selectedMateria = GetMateria();

            if (selectedMateria == null)
            {
                MessageBox.Show("Selecione uma matéria primeiro.", "Edição de Matéria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RegisterMateriaForm screen = new(_disciplineRepository)
            {
                Text = "Editando Matéria",

                Materia = selectedMateria,
                SaveRecord = _materiaRepository.Update
            };

            DialogResult dialogResult = screen.ShowDialog();

            if (dialogResult == DialogResult.OK)
                LoadMaterias();
        }

        public override void Delete()
        {
            Materia? selectedMateria = GetMateria();

            if (selectedMateria == null)
            {
                MessageBox.Show("Selecione uma matéria primeiro.", "Exclusão de Matéria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir este registro?", "Exclusão de Matéria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                ValidationResult validationResult = _materiaRepository.Delete(selectedMateria);

                if (validationResult.IsValid == false)
                {
                    MessageBox.Show($"\n{validationResult}", "Exclusão de Matéria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LoadMaterias();
            }
        }

        public override UserControl GetControl()
        {
            LoadMaterias();

            return materiaControl;
        }

        private void LoadMaterias()
        {
            List<Materia> materias = _materiaRepository.GetAll();

            materiaControl.UpdateGrid(materias);
        }

        private Materia? GetMateria()
        {
            if (materiaControl.GetGrid().CurrentCell != null && materiaControl.GetGrid().CurrentCell.Selected == true)
            {
                int index = materiaControl.GetSelectedRow();
                return _materiaRepository.GetAll().ElementAtOrDefault(index);   
            }

            return null;
        }
    }
}