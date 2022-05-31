using FluentValidation.Results;
using TestsGenerator.Domain.DisciplineModule;
using TestsGenerator.Domain.MateriaModule;
using TestsGenerator.Domain.Shared;
using TestsGenerator.Infra.Database.DisciplineModule;

namespace TestsGenerator.MateriaModule
{
    public partial class RegisterMateriaForm : Form
    {
        private Materia materia;

        public RegisterMateriaForm(DisciplineRepository disciplineRepository)
        {
            InitializeComponent();

            List<Bimester> bimesters = Enum.GetValues(typeof(Bimester)).Cast<Bimester>().ToList();

            bimesters.ForEach(x => CbxBimester.Items.Add(x));
            disciplineRepository.GetAll().ForEach(x => CbxDiscipline.Items.Add(x));
        }

        public Materia Materia
        {
            get { return materia; }

            set
            {
                materia = value;

                TxbName.Text = materia.Name;
                TxbGrade.Text = materia.Grade;
                CbxBimester.SelectedItem = materia.Bimester;
                CbxDiscipline.SelectedItem = materia.Discipline;
            }
        }

        public Func<Materia, ValidationResult> SaveRecord { get; set; }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            materia.Name = TxbName.Text;
            materia.Grade = TxbGrade.Text;

            if (CbxBimester.SelectedItem != null)
                materia.Bimester = (Bimester)CbxBimester.SelectedItem;

            materia.Discipline = (Discipline)CbxDiscipline.SelectedItem;

            ValidationResult validationResult = SaveRecord(materia);

            if (validationResult.IsValid == false)
            {
                MessageBox.Show(validationResult.ToString("\n"), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                DialogResult = DialogResult.None;
            }
        }
    }
}