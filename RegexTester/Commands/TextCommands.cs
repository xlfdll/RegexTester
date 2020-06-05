using System;
using System.Reflection;
using System.Windows;

using Xlfdll.Windows.Presentation;

namespace RegexTester.Commands
{
    public static class TextCommands
    {
        static TextCommands()
        {
            TextCommands.LoadTextCommand = new RelayCommand<String>
            (
                delegate (String argument)
                {
                    Type t = Type.GetType($"RegexTester.Windows.Text.LoadFrom{argument}TextWindow, {Assembly.GetExecutingAssembly().FullName}");

                    Window patternWindow = Activator.CreateInstance(t) as Window;

                    patternWindow.Owner = App.MainWindow;
                    patternWindow.ShowDialog();
                }
            );
        }

        public static RelayCommand<String> LoadTextCommand { get; }
    }
}