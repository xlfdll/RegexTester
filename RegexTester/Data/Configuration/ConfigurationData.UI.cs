using System.Windows;

using RegexTester.Helpers;

namespace RegexTester.Data.Configuration
{
    static partial class ConfigurationData
    {
        public static class UI
        {
            static UI()
            {
                ConfigurationHelper.AddValue("UI", "ResultRowHeight", "Auto");
            }

            public static GridLength ResultRowHeight
            {
                get
                {
                    return (GridLength)gridLengthConverter.ConvertFromInvariantString(ConfigurationHelper.Current["UI"]["ResultRowHeight"]);
                }
                set
                {
                    ConfigurationHelper.Current["UI"]["ResultRowHeight"] = value.ToString();
                }
            }

            private static GridLengthConverter gridLengthConverter = new GridLengthConverter();
        }
    }
}