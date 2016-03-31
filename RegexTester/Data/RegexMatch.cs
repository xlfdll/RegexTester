using System;
using System.Collections.ObjectModel;

namespace RegexTester.Data
{
    public class RegexMatch
    {
        public RegexMatch(String value, Int32 index)
        {
            this.Value = value;
            this.Index = index;
            this.Children = new ObservableCollection<RegexMatch>();
        }

        public String Value { get; }
        public Int32 Index { get; }
        public ObservableCollection<RegexMatch> Children { get; }
    }
}