using System.Reflection;
using System.Windows;

using Xlfdll.Core.Diagnostics;

using RegexTester.Windows;

namespace RegexTester.Helpers
{
    public static class ApplicationHelper
    {
        static ApplicationHelper()
        {
            ApplicationHelper.Metadata = new AssemblyMetadata(Assembly.GetExecutingAssembly());
        }

        public static AssemblyMetadata Metadata { get; private set; }
        public static MainWindow MainWindow
        {
            get { return Application.Current.MainWindow as MainWindow; }
        }
    }
}