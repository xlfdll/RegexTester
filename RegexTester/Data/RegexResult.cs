using System;
using System.Collections.ObjectModel;

using RegexTester.Helpers;

namespace RegexTester.Data
{
    public class RegexResult
    {
        public RegexResult()
        {
            this.Results = new ObservableCollection<RegexMatch>();
            this.IsAvailable = false;
            this.DurationTicks = 0;
            this.TimeStamp = DateTime.MinValue;
        }

        public ObservableCollection<RegexMatch> Results { get; }
        public Boolean IsAvailable { get; private set; }
        public Int64 DurationTicks { get; private set; }
        public DateTime TimeStamp { get; private set; }

        public Double DurationTime
            => ValueHelper.ConvertTicksToNanoseconds(this.DurationTicks);

        public void Update(Int64 elapsedTicks)
        {
            this.DurationTicks = elapsedTicks;
            this.TimeStamp = DateTime.Now;
            this.IsAvailable = true;
        }
    }
}