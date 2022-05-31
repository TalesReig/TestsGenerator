using FluentValidation.Results;
using TestsGenerator.Domain.DisciplineModule;
using TestsGenerator.Infra.Database.DisciplineModule;
using TestsGenerator.Infra.Database.MateriaModule;
using TestsGenerator.Shared;

namespace TestsGenerator.DisciplineModule
{
    public class DisciplineController : BaseController
    {
        private readonly DisciplineRepository _disciplineRepository;
        private readonly DisciplineControl disciplineControl;

        public DisciplineController(DisciplineRepository disciplineRepository, MateriaRepository materiaRepository)
        {
            _disciplineRepository = disciplineRepository;
            disciplineControl = new(this);
        }

        public override void Insert()
        {
            RegisterDisciplineForm screen = new()
            {
                Discipline = new(),
                SaveRecord = _disciplineRepository.Insert
            };

            DialogResult dialogResult = screen.ShowDialog();

            if (dialogResult == DialogResult.OK)
                LoadDisciplines();
        }

        public override void Update()
        {
            Discipline? selectedDiscipline = GetDiscipline();

            if (selectedDiscipline == null)
            {
                MessageBox.Show("Selecione uma disciplina primeiro.", "Edição de Disciplina", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RegisterDisciplineForm screen = new()
            {
                Text = "Editando Disciplina",

                Discipline = selectedDiscipline,
                SaveRecord = _disciplineRepository.Update
            };

            DialogResult dialogResult = screen.ShowDialog();

            if (dialogResult == DialogResult.OK)
                LoadDisciplines();
        }

        public override void Delete()
        {
            Discipline? selectedDiscipline = GetDiscipline();

            if (selectedDiscipline == null)
            {
                MessageBox.Show("Selecione uma disciplina primeiro.", "Exclusão de Disciplina", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir este registro?", "Exclusão de Disciplina", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                ValidationResult validationResult = _disciplineRepository.Delete(selectedDiscipline);

                if (validationResult.IsValid == false)
                {
                    MessageBox.Show($"\n{validationResult}", "Exclusão de Disciplina", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LoadDisciplines();
            }
        }

        public override UserControl GetControl()
        { 
            LoadDisciplines();

            return disciplineControl;
        }

        private void LoadDisciplines()
        {
            List<Discipline> disciplines = _disciplineRepository.GetAll();

            disciplineControl.UpdateGrid(disciplines);
        }

        private Discipline? GetDiscipline()
        {
            if (disciplineControl.GetGrid().CurrentCell != null && disciplineControl.GetGrid().CurrentCell.Selected == true)
            {
                int index = disciplineControl.GetSelectedRow();
                return _disciplineRepository.GetAll().ElementAtOrDefault(index);
            }

            return null;
        }
    }
}