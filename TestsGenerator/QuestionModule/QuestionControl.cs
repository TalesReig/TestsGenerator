using TestsGenerator.Domain.QuestionModule;

namespace TestsGenerator.QuestionModule
{
    public partial class QuestionControl : UserControl
    {
        private readonly QuestionController _questionController;

        public QuestionControl(QuestionController questionController)
        {
            InitializeComponent();

            _questionController = questionController;
        }

        public void UpdateGrid(List<Question> questions)
        {
            GridQuestions.Rows.Clear();

            questions.ForEach(question =>
            {
                GridQuestions.Rows.Add(
                    question.Id,
                    question.Description,
                    question.Grade,
                    question.Bimester,
                    question.Materia.Name,
                    question.Discipline.Name); 
            });

            GridQuestions.ClearSelection();
        }

        public int GetSelectedRow()
        {
            return GridQuestions.CurrentCell.RowIndex;
        }

        public DataGridView GetGrid()
        {
            return GridQuestions;
        }

        private void BtnRegisterQuestion_Click(object sender, EventArgs e)
        {
            _questionController.Insert();
        }

        private void BtnEditQuestion_Click(object sender, EventArgs e)
        {
            _questionController.Update();
        }

        private void BtnDeleteQuestion_Click(object sender, EventArgs e)
        {
            _questionController.Delete();
        }

        private void BtnAddAlternatives_Click(object sender, EventArgs e)
        {
            _questionController.AddAlternatives();
        }
    }
}