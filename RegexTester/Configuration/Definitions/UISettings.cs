using System.Windows;

using Xlfdll.Configuration;

using RegexTester.Helpers;

namespace RegexTester.Configuration
{
    public class UISettings : ApplicationSettings
    {
        public UISettings(ApplicationConfiguration appConfiguration)
            : base(appConfiguration)
        {
            this.Provider.Current.TryAddValue("UI", "ResultRowHeight", "Auto");
        }

        public GridLength ResultRowHeight
        {
            get
            {
                return (GridLength)ValueHelper.GridLengthConverter.ConvertFromInvariantString(this.Provider.Current["UI"]["ResultRowHeight"]);
            }
            set
            {
                this.Provider.Current["UI"]["ResultRowHeight"] = value.ToString();
            }
        }
    }
}