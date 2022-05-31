using FluentValidation;
using FluentValidation.Results;
using TestsGenerator.Domain.AlternativeModule;
using TestsGenerator.Domain.QuestionModule;
using TestsGenerator.Infra.Database.QuestionModule;

namespace TestsGenerator.AlternativeModule
{
    public partial class RegisterAlternativeForm : Form
    {
        private readonly QuestionRepository _questionRepository;
        private readonly Question _question;

        public RegisterAlternativeForm(QuestionRepository questionRepository, Question question)
        {
            InitializeComponent();

            _question = question;
            _questionRepository = questionRepository;

            TxbSelectedQuestion.Text = question.Id.ToString();

            question.Alternatives.ForEach(x => ListAlternatives.Items.Add(x));
        }

        public List<Alternative> RegisteredAlternatives
        {
            get { return ListAlternatives.Items.Cast<Alternative>().ToList(); }
        }

        private void BtnAddAlternative_Click(object sender, EventArgs e)
        { 

            Alternative alternative = new()
            {
                Letter = TxbLetter.Text,
                IsCorrect = ChbIsCorret.Checked,
                Description = TxbDescription.Text,
                Question = _question,
            };

            AlternativeValidator validator = new();

            ValidationResult validationResult = validator.Validate(alternative);

            if (validationResult.IsValid == false)
            {
                MessageBox.Show(validationResult.ToString("\n"), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ListAlternatives.Items.Add(alternative);

            TxbLetter.Clear();
            ChbIsCorret.Checked = false;
            TxbDescription.Clear();
        }

        private void BtnEditAlternative_Click(object sender, EventArgs e)
        {
            if (ListAlternatives.SelectedItem is Alternative selectedItem)
            {
                selectedItem.Letter = TxbLetter.Text;
                selectedItem.IsCorrect = ChbIsCorret.Checked;
                selectedItem.Description = TxbDescription.Text;
                selectedItem.Question = _question;

                AlternativeValidator validator = new();

                ValidationResult validationResult = validator.Validate(selectedItem);

                if (validationResult.IsValid == false)
                {
                    MessageBox.Show(validationResult.ToString("\n"), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                int index = ListAlternatives.SelectedIndex;

                ListAlternatives.Items.RemoveAt(index);
                ListAlternatives.Items.Insert(index, selectedItem);

                _questionRepository.UpdateAlternative(selectedItem);
            }

            TxbLetter.Clear();
            ChbIsCorret.Checked = false;
            TxbDescription.Clear();

            ListAlternatives.ClearSelected();

            TxbLetter.Enabled = true;
        }

        private void BtnDeleteAlternative_Click(object sender, EventArgs e)
        {

            if (ListAlternatives.SelectedItem is Alternative selectedItem)
            {
                int index = ListAlternatives.SelectedIndex;

                TxbLetter.Clear();
                ChbIsCorret.Checked = false;
                TxbDescription.Clear();

                _questionRepository.DeleteAlternative(selectedItem);

                ListAlternatives.Items.RemoveAt(index);
            }
        }

        private void ListAlternatives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListAlternatives.SelectedItem is Alternative selectedItem)
            {
                TxbLetter.Text = selectedItem.Letter;
                TxbLetter.Enabled = false;
                ChbIsCorret.Checked = selectedItem.IsCorrect;
                TxbDescription.Text = selectedItem.Description;
            }
        }
    }
}