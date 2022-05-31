using TestsGenerator.Domain.QuestionModule;

namespace TestsGenerator.Domain.AlternativeModule
{
    public class Alternative
    {
        public int Id { get; set; }
        public string Letter { get; set; }
        public bool IsCorrect { get; set; }
        public string Description { get; set; }
        public Question Question { get; set; }

        public override string ToString()
        {
            return $"{Letter}) {Description}";
        }
    }
}