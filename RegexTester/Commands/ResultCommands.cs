using System.Windows;

using Xlfdll.Windows.Presentation;

using RegexTester.Data;

namespace RegexTester.Commands
{
    public static class ResultCommands
    {
        static ResultCommands()
        {
            ResultCommands.CopyValueCommand = new RelayCommand<RegexMatch>
            (
                delegate (RegexMatch parameter)
                {
                    Clipboard.SetText(parameter.Value);
                },
                delegate (RegexMatch parameter)
                {
                    return (parameter != null);
                }
            );
        }

        public static RelayCommand<RegexMatch> CopyValueCommand { get; }
    }
}