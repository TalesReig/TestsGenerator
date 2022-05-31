using FluentValidation.Results;
using TestsGenerator.AlternativeModule;
using TestsGenerator.Domain.AlternativeModule;
using TestsGenerator.Domain.QuestionModule;
using TestsGenerator.Infra.Database.DisciplineModule;
using TestsGenerator.Infra.Database.MateriaModule;
using TestsGenerator.Infra.Database.QuestionModule;
using TestsGenerator.Shared;

namespace TestsGenerator.QuestionModule
{
    public class QuestionController : BaseController
    {
        private readonly QuestionRepository _questionRepository;
        private readonly MateriaRepository _materiaRepository;
        private readonly DisciplineRepository _disciplineRepository;

        private readonly QuestionControl questionControl;

        public QuestionController(QuestionRepository questionRepository, MateriaRepository materiaRepository, DisciplineRepository disciplineRepository)
        {
            _questionRepository = questionRepository;
            _materiaRepository = materiaRepository;
            _disciplineRepository = disciplineRepository;
            questionControl = new(this);
        }

        public override void Insert()
        {
            RegisterQuestionForm screen = new(_disciplineRepository, _materiaRepository)
            {
                Question = new(),
                SaveRecord = _questionRepository.Insert
            };

            DialogResult dialogResult = screen.ShowDialog();

            if (dialogResult == DialogResult.OK)
                LoadQuestions();

            _questionRepository.AddAlternatives(screen.Question, screen.Question.Alternatives);
        }

        public override void Update()
        {
            Question? selectedQuestion = GetQuestion();

            if (selectedQuestion == null)
            {
                MessageBox.Show("Selecione uma questão primeiro.", "Edição de Questão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RegisterQuestionForm screen = new(_disciplineRepository, _materiaRepository)
            {
                Text = "Editando Questão",

                Question = selectedQuestion,
                SaveRecord = _questionRepository.Update
            };

            DialogResult dialogResult = screen.ShowDialog();

            if (dialogResult == DialogResult.OK)
                LoadQuestions();
        }

        public override void Delete()
        {
            Question? selectedQuestion = GetQuestion();

            if (selectedQuestion == null)
            {
                MessageBox.Show("Selecione uma questão primeiro.", "Exclusão de Questão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir este registro?", "Exclusão de Questão", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                ValidationResult validationResult = _questionRepository.Delete(selectedQuestion);

                if (validationResult.IsValid == false)
                {
                    MessageBox.Show($"\n{validationResult}", "Exclusão de Questão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LoadQuestions();
            }
        }

        public void AddAlternatives()
        {
            Question? selectedQuestion = GetQuestion();

            if (selectedQuestion == null)
            {
                MessageBox.Show("Selecione uma questão primeiro.", "Exclusão de Questão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RegisterAlternativeForm screen = new(_questionRepository, selectedQuestion);

            if (screen.ShowDialog() == DialogResult.OK)
            {
                _questionRepository.AddAlternatives(selectedQuestion, screen.RegisteredAlternatives);

                LoadQuestions();
            }
        }

        public override UserControl GetControl()
        {
            LoadQuestions();

            return questionControl;
        }

        private void LoadQuestions()
        {
            List<Question> questions = _questionRepository.GetAll();

            questionControl.UpdateGrid(questions);
        }

        private Question? GetQuestion()
        {
            if (questionControl.GetGrid().CurrentCell != null && questionControl.GetGrid().CurrentCell.Selected == true)
            {
                int index = questionControl.GetSelectedRow();
                return _questionRepository.GetAll().ElementAtOrDefault(index);
            }

            return null;
        }
    }
}