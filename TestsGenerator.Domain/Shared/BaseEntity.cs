namespace TestsGenerator.Domain.Shared
{
    public abstract class BaseEntity<T>
    {
        public int Id { get; set; }

        public abstract void Update(T t);
    }
}