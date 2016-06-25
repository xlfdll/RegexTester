using System;
using System.Collections.Generic;

using Xlfdll.Core;

namespace RegexTester.Configuration
{
    public class HistorySettings : ApplicationSettings
    {
        public HistorySettings(ApplicationConfiguration appConfiguration)
            : base(appConfiguration)
        {
            this.Provider.Current.TryAddValue("History", "RecentRegexPatternCount", "10");
            this.Provider.Current.TryAddValue("History", "RecentReplacePatternCount", "10");

            this.RecentRegexPatterns = new List<String>();
            this.RecentReplacePatterns = new List<String>();

            for (Int32 i = 0; i < this.RecentRegexPatternCount; i++)
            {
                this.Provider.Current.TryAddValue("History", "RecentRegexPattern" + (i + 1).ToString(), String.Empty);
                this.RecentRegexPatterns.Add(this.Provider.Current["History"]["RecentRegexPattern" + (i + 1).ToString()]);
            }

            for (Int32 i = 0; i < this.RecentReplacePatternCount; i++)
            {
                this.Provider.Current.TryAddValue("History", "RecentReplacePattern" + (i + 1).ToString(), String.Empty);
                this.RecentReplacePatterns.Add(this.Provider.Current["History"]["RecentReplacePattern" + (i + 1).ToString()]);
            }
        }

        public List<String> RecentRegexPatterns { get; }
        public List<String> RecentReplacePatterns { get; }

        public Int32 RecentRegexPatternCount
        {
            get
            {
                return Convert.ToInt32(this.Provider.Current["History"]["RecentRegexPatternCount"]);
            }
            set
            {
                this.Provider.Current["History"]["RecentRegexPatternCount"] = value.ToString();
            }
        }
        public Int32 RecentReplacePatternCount
        {
            get
            {
                return Convert.ToInt32(this.Provider.Current["History"]["RecentReplacePatternCount"]);
            }
            set
            {
                this.Provider.Current["History"]["RecentReplacePatternCount"] = value.ToString();
            }
        }

        public void AddRecentRegexPattern(String item)
        {
            Int32 index = this.RecentRegexPatterns.IndexOf(item);

            if (index != -1)
            {
                this.RecentRegexPatterns.RemoveAt(index);
            }

            this.RecentRegexPatterns.Insert(0, item);

            if (this.RecentRegexPatterns.Count > this.RecentRegexPatternCount)
            {
                this.RecentRegexPatterns.RemoveAt(this.RecentRegexPatterns.Count - 1);
            }

            for (Int32 i = 0; i < this.RecentRegexPatternCount; i++)
            {
                this.Provider.Current["History"]["RecentRegexPattern" + (i + 1).ToString()] = this.RecentRegexPatterns[i];
            }
        }
        public void AddRecentReplacePattern(String item)
        {
            Int32 index = this.RecentReplacePatterns.IndexOf(item);

            if (index != -1)
            {
                this.RecentReplacePatterns.RemoveAt(index);
            }

            this.RecentReplacePatterns.Insert(0, item);

            if (this.RecentReplacePatterns.Count > this.RecentReplacePatternCount)
            {
                this.RecentReplacePatterns.RemoveAt(this.RecentReplacePatterns.Count - 1);
            }

            for (Int32 i = 0; i < this.RecentReplacePatternCount; i++)
            {
                this.Provider.Current["History"]["RecentReplacePattern" + (i + 1).ToString()] = this.RecentReplacePatterns[i];
            }
        }
    }
}