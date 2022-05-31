using TestsGenerator.Infra.Shared;
using TestsGenerator.Infra.Shared.Serializators;

namespace TestsGenerator
{
    internal static class Program
    {
        static readonly ISerializator serializator = new JsonSerializator();
        static readonly DataContext dataContext = new(serializator);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new DashboardForm(dataContext));
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            dataContext.Save();
        }
    }
}