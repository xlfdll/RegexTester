﻿using System.Windows;

using RegexTester.Helpers;

namespace RegexTester.Data.Configuration
{
    static partial class ConfigurationData
    {
        public static class UI
        {
            static UI()
            {
                ApplicationHelper.Settings.Current.TryAddValue("UI", "ResultRowHeight", "Auto");
            }

            public static GridLength ResultRowHeight
            {
                get
                {
                    return (GridLength)gridLengthConverter.ConvertFromInvariantString(ApplicationHelper.Settings.Current["UI"]["ResultRowHeight"]);
                }
                set
                {
                    ApplicationHelper.Settings.Current["UI"]["ResultRowHeight"] = value.ToString();
                }
            }

            private static GridLengthConverter gridLengthConverter = new GridLengthConverter();
        }
    }
}