using FluentValidation.Results;
using TestsGenerator.Domain.DisciplineModule;

namespace TestsGenerator.DisciplineModule
{
    public partial class RegisterDisciplineForm : Form
    {
        private Discipline discipline;

        public RegisterDisciplineForm()
        {
            InitializeComponent();
        }

        public Discipline Discipline
        {
            get { return discipline; }

            set
            {
                discipline = value;

                TxbDisciplineName.Text = discipline.Name;
            }
        }

        public Func<Discipline, ValidationResult> SaveRecord { get; set; }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            discipline.Name = TxbDisciplineName.Text;

            ValidationResult validationResult = SaveRecord(discipline);

            if (validationResult.IsValid == false)
            {
                MessageBox.Show(validationResult.ToString("\n"), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                DialogResult = DialogResult.None;

            }
        }
    }
}