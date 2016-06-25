using System;
using System.Collections.Generic;

using RegexTester.Helpers;

namespace RegexTester
{
    public static partial class Settings
    {
        public static class History
        {
            static History()
            {
                ApplicationHelper.Settings.Current.TryAddValue("History", "RecentRegexPatternCount", "10");
                ApplicationHelper.Settings.Current.TryAddValue("History", "RecentReplacePatternCount", "10");

                Settings.History.RecentRegexPatterns = new List<String>();
                Settings.History.RecentReplacePatterns = new List<String>();

                for (Int32 i = 0; i < Settings.History.RecentRegexPatternCount; i++)
                {
                    ApplicationHelper.Settings.Current.TryAddValue("History", "RecentRegexPattern" + (i + 1).ToString(), String.Empty);
                    Settings.History.RecentRegexPatterns.Add(ApplicationHelper.Settings.Current["History"]["RecentRegexPattern" + (i + 1).ToString()]);
                }

                for (Int32 i = 0; i < Settings.History.RecentReplacePatternCount; i++)
                {
                    ApplicationHelper.Settings.Current.TryAddValue("History", "RecentReplacePattern" + (i + 1).ToString(), String.Empty);
                    Settings.History.RecentReplacePatterns.Add(ApplicationHelper.Settings.Current["History"]["RecentReplacePattern" + (i + 1).ToString()]);
                }
            }

            public static Int32 RecentRegexPatternCount
            {
                get
                {
                    return Convert.ToInt32(ApplicationHelper.Settings.Current["History"]["RecentRegexPatternCount"]);
                }
                set
                {
                    ApplicationHelper.Settings.Current["History"]["RecentRegexPatternCount"] = value.ToString();
                }
            }
            public static Int32 RecentReplacePatternCount
            {
                get
                {
                    return Convert.ToInt32(ApplicationHelper.Settings.Current["History"]["RecentReplacePatternCount"]);
                }
                set
                {
                    ApplicationHelper.Settings.Current["History"]["RecentReplacePatternCount"] = value.ToString();
                }
            }

            public static List<String> RecentRegexPatterns { get; private set; }
            public static List<String> RecentReplacePatterns { get; private set; }

            public static void AddRecentRegexPattern(String item)
            {
                Int32 index = Settings.History.RecentRegexPatterns.IndexOf(item);

                if (index != -1)
                {
                    Settings.History.RecentRegexPatterns.RemoveAt(index);
                }

                Settings.History.RecentRegexPatterns.Insert(0, item);

                if (Settings.History.RecentRegexPatterns.Count > Settings.History.RecentRegexPatternCount)
                {
                    Settings.History.RecentRegexPatterns.RemoveAt(Settings.History.RecentRegexPatterns.Count - 1);
                }

                for (Int32 i = 0; i < Settings.History.RecentRegexPatternCount; i++)
                {
                    ApplicationHelper.Settings.Current["History"]["RecentRegexPattern" + (i + 1).ToString()] = Settings.History.RecentRegexPatterns[i];
                }
            }
            public static void AddRecentReplacePattern(String item)
            {
                Int32 index = Settings.History.RecentReplacePatterns.IndexOf(item);

                if (index != -1)
                {
                    Settings.History.RecentReplacePatterns.RemoveAt(index);
                }

                Settings.History.RecentReplacePatterns.Insert(0, item);

                if (Settings.History.RecentReplacePatterns.Count > Settings.History.RecentReplacePatternCount)
                {
                    Settings.History.RecentReplacePatterns.RemoveAt(Settings.History.RecentReplacePatterns.Count - 1);
                }

                for (Int32 i = 0; i < Settings.History.RecentReplacePatternCount; i++)
                {
                    ApplicationHelper.Settings.Current["History"]["RecentReplacePattern" + (i + 1).ToString()] = Settings.History.RecentReplacePatterns[i];
                }
            }
        }
    }
}