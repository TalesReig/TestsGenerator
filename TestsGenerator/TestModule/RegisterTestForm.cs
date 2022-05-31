using FluentValidation.Results;
using System.Data;
using TestsGenerator.Domain.DisciplineModule;
using TestsGenerator.Domain.MateriaModule;
using TestsGenerator.Domain.QuestionModule;
using TestsGenerator.Domain.Shared;
using TestsGenerator.Domain.TestModule;

namespace TestsGenerator.TestModule
{
    public partial class RegisterTestForm : Form
    {
        private Test test;
        private readonly List<Question> _questions;
        private readonly List<Materia> _materias;

        public RegisterTestForm(List<Discipline> disciplines, List<Materia> materias, List<Question> questions)
        {
            InitializeComponent();

            _materias = materias;
            _questions = questions;

            disciplines.ForEach(x => CbxDiscipline.Items.Add(x));
        }

        public Test Test
        {
            get { return test; }

            set { test = value; }
        }

        public Func<Test, ValidationResult> SaveRecord { get; set; }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            test.Title = TxbTitle.Text;
            test.Discipline = (Discipline)CbxDiscipline.SelectedItem;
            test.Grade = (string)CbxGrade.SelectedItem;

            if (CbxBimester.SelectedItem != null)
                test.Bimester = (Bimester)CbxBimester.SelectedItem;

            test.Materia = (Materia)CbxMateria.SelectedItem;

            foreach (Question item in ClbxAvailableQuestions.Items)
            {
                if (ClbxAvailableQuestions.CheckedItems.Contains(item))
                {
                    if (test.Questions.Contains(item))
                        return;

                    test.Questions.Add(item);
                }
            }

            ValidationResult validationResult = SaveRecord(test);

            if (validationResult.IsValid == false)
            {
                MessageBox.Show(validationResult.ToString("\n"), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                DialogResult = DialogResult.None;
            }
        }

        private void CbxDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbxGrade.Items.Clear();
            CbxBimester.Items.Clear();
            CbxMateria.Items.Clear();
            ClbxAvailableQuestions.Items.Clear();

            List<string> grades = _materias
                .Where(x => x.Discipline == (Discipline)CbxDiscipline.SelectedItem)
                .Select(y => y.Grade)
                .Distinct()
                .ToList();

            grades.ForEach(x => CbxGrade.Items.Add(x));
        }

        private void CbxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbxBimester.Items.Clear();
            CbxMateria.Items.Clear();

            List<Bimester> bimesters = Enum
                .GetValues(typeof(Bimester))
                .Cast<Bimester>()
                .ToList();

            bimesters.ForEach(x => CbxBimester.Items.Add(x));
        }

        private void CbxBimester_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbxMateria.Items.Clear();

            List<Materia> materias = _materias
                .Where(x =>
                x.Discipline == (Discipline)CbxDiscipline.SelectedItem &&
                x.Grade == (string)CbxGrade.SelectedItem &&
                x.Bimester == (Bimester)CbxBimester.SelectedItem)
                .ToList();

            materias.ForEach(x => CbxMateria.Items.Add(x));
        }

        private void CbxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Question> questions = _questions
                .Where(x =>
                x.Discipline == (Discipline)CbxDiscipline.SelectedItem &&
                x.Grade == (string)CbxGrade.SelectedItem &&
                x.Bimester == (Bimester)CbxBimester.SelectedItem &&
                x.Materia == (Materia)CbxMateria.SelectedItem)
                .ToList();

            questions.ForEach(x => ClbxAvailableQuestions.Items.Add(x));
        }
    }
}