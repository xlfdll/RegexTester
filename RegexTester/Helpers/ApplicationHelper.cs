using System.Reflection;
using System.Windows;

using Xlfdll.Core;
using Xlfdll.Core.Diagnostics;
using Xlfdll.Windows.Configuration;

using RegexTester.Windows;

namespace RegexTester.Helpers
{
    public static class ApplicationHelper
    {
        static ApplicationHelper()
        {
            ApplicationHelper.Metadata = new AssemblyMetadata(Assembly.GetExecutingAssembly());
            ApplicationHelper.Configuration = new ApplicationConfiguration(new RegistryConfigurationProcessor(@"Xlfdll\RegexTester", RegistryConfigurationScope.User));
            ApplicationHelper.Settings = new Settings(ApplicationHelper.Configuration);
        }

        public static AssemblyMetadata Metadata { get; }
        public static ApplicationConfiguration Configuration { get; }
        public static Settings Settings { get; }

        public static MainWindow MainWindow
        {
            get { return Application.Current.MainWindow as MainWindow; }
        }
    }
}