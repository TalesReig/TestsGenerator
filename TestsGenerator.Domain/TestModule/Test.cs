using TestsGenerator.Domain.DisciplineModule;
using TestsGenerator.Domain.MateriaModule;
using TestsGenerator.Domain.QuestionModule;
using TestsGenerator.Domain.Shared;

namespace TestsGenerator.Domain.TestModule
{
    public class Test : BaseEntity<Test>
    {
        public string Title { get; set; }
        public string Grade { get; set; }
        public Bimester? Bimester { get; set; }
        public Discipline Discipline { get; set; }
        public Materia Materia { get; set; }

        public List<Question> Questions = new();

        public override void Update(Test t)
        {
            Title = t.Title;
            Grade = t.Grade;
            Bimester = t.Bimester;
            Discipline = t.Discipline;
            Materia = t.Materia;
            Questions = t.Questions;
        }

        public Test Clone()
        {
            return MemberwiseClone() as Test;
        }
    }
}