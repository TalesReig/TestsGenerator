namespace TestsGenerator.Infra.Shared.Serializators
{
    public interface ISerializator
    {
        DataContext Load();
        void Save(DataContext dataContext);
    }
}