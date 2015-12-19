using System.Windows.Input;

namespace RegexTester.Commands
{
    public static class RegexCommands
    {
        static RegexCommands()
        {
            RegexCommands.MatchCommand = new RoutedUICommand("Match", "Match", typeof(RegexCommands),
                new InputGestureCollection() { new KeyGesture(Key.M, ModifierKeys.Control, "Ctrl+M") });
            RegexCommands.SplitCommand = new RoutedUICommand("Split", "Split", typeof(RegexCommands),
                new InputGestureCollection() { new KeyGesture(Key.L, ModifierKeys.Control, "Ctrl+L") });
            RegexCommands.ReplaceCommand = new RoutedUICommand("Replace", "Replace", typeof(RegexCommands),
                new InputGestureCollection() { new KeyGesture(Key.P, ModifierKeys.Control, "Ctrl+P") });
            RegexCommands.MeasureCommand = new RoutedUICommand("Measure", "Measure", typeof(RegexCommands),
                new InputGestureCollection() { new KeyGesture(Key.E, ModifierKeys.Control, "Ctrl+E") });
            RegexCommands.EditCommand = new RoutedUICommand("Edit", "Edit", typeof(RegexCommands));
        }

        public static RoutedUICommand MatchCommand { get; private set; }
        public static RoutedUICommand SplitCommand { get; private set; }
        public static RoutedUICommand ReplaceCommand { get; private set; }
        public static RoutedUICommand MeasureCommand { get; private set; }
        public static RoutedUICommand EditCommand { get; private set; }
    }
}