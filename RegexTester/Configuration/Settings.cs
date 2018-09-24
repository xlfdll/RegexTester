using Xlfdll.Configuration;

using RegexTester.Configuration;

namespace RegexTester
{
    public class Settings
    {
        public Settings(ApplicationConfiguration appConfiguration)
        {
            this.Main = new MainSettings(appConfiguration);
            this.UI = new UISettings(appConfiguration);
            this.History = new HistorySettings(appConfiguration);
        }

        public MainSettings Main { get; }
        public UISettings UI { get; }
        public HistorySettings History { get; }
    }
}