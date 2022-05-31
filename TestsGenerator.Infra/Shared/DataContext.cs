using TestsGenerator.Domain.DisciplineModule;
using TestsGenerator.Domain.MateriaModule;
using TestsGenerator.Domain.QuestionModule;
using TestsGenerator.Domain.TestModule;
using TestsGenerator.Infra.Shared.Serializators;

namespace TestsGenerator.Infra.Shared
{
    public class DataContext
    { 
        private readonly ISerializator _serializator;

        public DataContext()
        {
            Disciplines = new();
            Materias = new();
            Questions = new();
            Tests = new();
        }

        public DataContext(ISerializator serializator) : this()
        {
            _serializator = serializator;

            Load();
        }

        public List<Discipline> Disciplines { get; set; }

        public List<Materia> Materias { get; set; }

        public List<Question> Questions { get; set; }

        public List<Test> Tests { get; set; }

        public void Save()
        {
            _serializator.Save(this);
        }

        private void Load()
        {
            DataContext dataContext = _serializator.Load();

            if (dataContext.Disciplines.Any()) 
                Disciplines.AddRange(dataContext.Disciplines);

            if (dataContext.Materias.Any())
                Materias.AddRange(dataContext.Materias);

            if (dataContext.Questions.Any())
                Questions.AddRange(dataContext.Questions);

            if (dataContext.Tests.Any())
                Tests.AddRange(dataContext.Tests);
        }
    }
}