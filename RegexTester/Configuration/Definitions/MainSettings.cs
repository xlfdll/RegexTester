using System;
using System.Text.RegularExpressions;

using Xlfdll.Core;

namespace RegexTester.Configuration
{
    public class MainSettings : ApplicationSettings
    {
        public MainSettings(ApplicationConfiguration appConfiguration)
            : base(appConfiguration)
        {
            this.Provider.Current.TryAddValue("Main", "RegexOperationTimeout", Regex.InfiniteMatchTimeout.ToString());
        }

        public TimeSpan RegexOperationTimeout
        {
            get
            {
                return TimeSpan.Parse(this.Provider.Current["Main"]["RegexOperationTimeout"]);
            }
            set
            {
                this.Provider.Current["Main"]["RegexOperationTimeout"] = value.ToString();
            }
        }
    }
}