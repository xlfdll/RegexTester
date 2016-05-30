using System.Windows;

using Xlfdll.Windows.Presentation;

using RegexTester.Data;

namespace RegexTester.Commands
{
    public static class ResultCommands
    {
        static ResultCommands()
        {
            ResultCommands.CopyValueCommand = new RelayCommand<RegexMatch>(
                (RegexMatch parameter) =>
                {
                    Clipboard.SetText(parameter.Value);
                },
                (RegexMatch parameter) =>
                {
                    return (parameter != null);
                });
        }

        public static RelayCommand<RegexMatch> CopyValueCommand { get; }
    }
}