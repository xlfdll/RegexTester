using System;
using System.Collections.ObjectModel;
using System.Diagnostics;

using RegexTester.Helpers;

namespace RegexTester.Data
{
    public class RegexResult
    {
        public RegexResult()
        {
            this.IsAvailable = false;
            this.Results = new ObservableCollection<RegexMatch>();
            this.DurationTicks = 0;
            this.TimeStamp = DateTime.MinValue;
        }

        public Boolean IsAvailable { get; private set; }
        public ObservableCollection<RegexMatch> Results { get; private set; }
        public Int64 DurationTicks { get; private set; }
        public DateTime TimeStamp { get; private set; }

        public Double DurationTime
        {
            get { return ValueHelper.ConvertTicksToNanoseconds(this.DurationTicks); }
        }

        public void Update(Int64 elapsedTicks)
        {
            this.DurationTicks = elapsedTicks;
            this.TimeStamp = DateTime.Now;
            this.IsAvailable = true;
        }
    }
}