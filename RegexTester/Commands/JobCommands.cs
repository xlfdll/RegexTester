using System.Windows.Input;

namespace RegexTester.Commands
{
    public static class JobCommands
    {
        static JobCommands()
        {
            JobCommands.NewCommand = new RoutedUICommand("New Job", "New", typeof(JobCommands),
                new InputGestureCollection() { new KeyGesture(Key.N, ModifierKeys.Control, "Ctrl+N") });
            JobCommands.OpenCommand = new RoutedUICommand("Open Job", "Open", typeof(JobCommands),
                new InputGestureCollection() { new KeyGesture(Key.O, ModifierKeys.Control, "Ctrl+O") });
            JobCommands.SaveCommand = new RoutedUICommand("Save Job", "Save", typeof(JobCommands),
                new InputGestureCollection() { new KeyGesture(Key.S, ModifierKeys.Control, "Ctrl+S") });
            JobCommands.SaveAsCommand = new RoutedUICommand("Save Job As", "Save As", typeof(JobCommands),
                new InputGestureCollection());
        }

        public static RoutedUICommand NewCommand { get; private set; }
        public static RoutedUICommand OpenCommand { get; private set; }
        public static RoutedUICommand SaveCommand { get; private set; }
        public static RoutedUICommand SaveAsCommand { get; private set; }
    }
}