using FluentValidation.Results;
using System.Data;
using TestsGenerator.Domain.DisciplineModule;
using TestsGenerator.Domain.MateriaModule;
using TestsGenerator.Domain.QuestionModule;
using TestsGenerator.Domain.Shared;
using TestsGenerator.Infra.Database.DisciplineModule;
using TestsGenerator.Infra.Database.MateriaModule;
using TestsGenerator.Infra.Database.QuestionModule;

namespace TestsGenerator.QuestionModule
{
    public partial class RegisterQuestionForm : Form
    {
        private Question question;
        private readonly DisciplineRepository _disciplineRepository;
        private readonly MateriaRepository _materiaRepository;

        public RegisterQuestionForm(DisciplineRepository disciplineRepository, MateriaRepository materiaRepository)
        {
            InitializeComponent();

            _disciplineRepository = disciplineRepository;
            _materiaRepository = materiaRepository;

            _disciplineRepository.GetAll().ForEach(x => CbxDiscipline.Items.Add(x));
        }

        public Question Question
        {
            get { return question; }

            set
            {
                question = value;

                CbxDiscipline.SelectedItem = question.Discipline;
                CbxGrade.SelectedItem = question.Grade;
                CbxBimester.SelectedItem = question.Bimester;
                CbxMateria.SelectedItem = question.Materia;
                RTxbDescription.Text = question.Description;
            }
        }

        public Func<Question, ValidationResult> SaveRecord { get; set; }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            question.Discipline = (Discipline)CbxDiscipline.SelectedItem;
            question.Grade = (string)CbxGrade.SelectedItem;

            if (CbxBimester.SelectedItem != null)
                question.Bimester = (Bimester)CbxBimester.SelectedItem;

            question.Materia = (Materia)CbxMateria.SelectedItem;
            question.Description = RTxbDescription.Text;

            ValidationResult validationResult = SaveRecord(question);

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

            List<string> grades = _materiaRepository.GetAll()
                .Where(x => x.Discipline.Equals(CbxDiscipline.SelectedItem))
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

            List<Materia> materias = _materiaRepository.GetAll()
                .Where(x =>
                x.Discipline.Equals(CbxDiscipline.SelectedItem) &&
                x.Grade == (string)CbxGrade.SelectedItem &&
                x.Bimester == (Bimester)CbxBimester.SelectedItem)
                .ToList();

            materias.ForEach(x => CbxMateria.Items.Add(x));
        }

        private void CbxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            question.Materia = (Materia)CbxMateria.SelectedItem;
        }
    }
}