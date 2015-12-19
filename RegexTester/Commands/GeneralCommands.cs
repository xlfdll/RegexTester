using System.Windows.Input;

namespace RegexTester.Commands
{
    public static class GeneralCommands
    {
        static GeneralCommands()
        {
            GeneralCommands.AboutCommand = new RoutedUICommand("About", "About", typeof(GeneralCommands),
                new InputGestureCollection() { new KeyGesture(Key.A, ModifierKeys.Control, "Ctrl+A") });
        }

        public static RoutedUICommand AboutCommand { get; private set; }
    }
}