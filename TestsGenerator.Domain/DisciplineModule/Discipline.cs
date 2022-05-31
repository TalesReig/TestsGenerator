using TestsGenerator.Domain.Shared;

namespace TestsGenerator.Domain.DisciplineModule
{
    public class Discipline : BaseEntity<Discipline>
    {
        public string Name { get; set; }

        public override void Update(Discipline t)
        {
            Name = t.Name;
        }

        public override bool Equals(object? obj)
        {
            return obj is Discipline discipline &&
                   Id == discipline.Id &&
                   Name == discipline.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}