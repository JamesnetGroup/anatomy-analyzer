using VickyApp.Properties;

namespace VickyApp
{
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App()
                .InitializeResource<ResourceSettings>()
                .Run();
        }
    }
}
