using System.Windows;

using RegexTester.Helpers;

namespace RegexTester
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            ApplicationHelper.Settings.Save();
        }
    }
}