using DemoApp.Properties;

namespace DemoApp
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
