using TestsGenerator.Domain.DisciplineModule;
using TestsGenerator.Domain.Shared;

namespace TestsGenerator.Domain.MateriaModule
{
    public class Materia : BaseEntity<Materia>
    {
        public string Name { get; set; }
        public string Grade { get; set; }
        public Bimester? Bimester { get; set; }
        public Discipline Discipline { get; set; }

        public override void Update(Materia t)
        {
            Name = t.Name;
            Grade = t.Grade;
            Bimester = t.Bimester;
            Discipline = t.Discipline;
        }

        public override bool Equals(object? obj)
        {
            return obj is Materia materia &&
                   Id == materia.Id &&
                   Name == materia.Name &&
                   Grade == materia.Grade &&
                   Bimester == materia.Bimester &&
                   EqualityComparer<Discipline>.Default.Equals(Discipline, materia.Discipline);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Grade, Bimester, Discipline);
        }
    }
}