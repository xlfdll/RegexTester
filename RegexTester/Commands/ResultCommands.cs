using System.Windows.Input;

namespace RegexTester.Commands
{
    public static class ResultCommands
    {
        static ResultCommands()
        {
            ResultCommands.CopyValueCommand = new RoutedUICommand("Copy Value", "Copy", typeof(ResultCommands),
                new InputGestureCollection() { new KeyGesture(Key.C, ModifierKeys.Control, "Ctrl+C") });
        }

        public static RoutedUICommand CopyValueCommand { get; private set; }
    }
}