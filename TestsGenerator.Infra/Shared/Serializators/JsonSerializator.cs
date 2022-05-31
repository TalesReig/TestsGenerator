using Newtonsoft.Json;

namespace TestsGenerator.Infra.Shared.Serializators
{
    public class JsonSerializator : ISerializator
    {
        private const string filePath = @"C:\temp\dados.json";
        private readonly JsonSerializerSettings settings;

        public JsonSerializator()
        {
            settings = new();
            settings.Formatting = Formatting.Indented;
            settings.PreserveReferencesHandling = PreserveReferencesHandling.All;
        }

        public DataContext Load()
        {
            if (File.Exists(filePath) == false)
                return new DataContext();

            string jsonFile = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<DataContext>(jsonFile, settings);
        }

        public void Save(DataContext dataContext)
        { 
            string jsonFile = JsonConvert.SerializeObject(dataContext, settings);

            File.WriteAllText(filePath, jsonFile);
        }
    }
}