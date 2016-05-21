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
            ApplicationHelper.Settings = new ApplicationConfiguration(new RegistryConfigurationProcessor(@"Xlfdll\RegexTester", RegistryConfigurationScope.User));
        }

        public static AssemblyMetadata Metadata { get; }
        public static ApplicationConfiguration Settings { get; }

        public static MainWindow MainWindow
        {
            get { return Application.Current.MainWindow as MainWindow; }
        }
    }
}