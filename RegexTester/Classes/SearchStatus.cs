using System;

namespace RegexTester
{
    internal class SearchStatus
    {
        internal SearchStatus(RegexInput input, DateTime dateTimeStamp, Double tick)
        {
            _input = input;
            _dateTimeStamp = dateTimeStamp;
            _tick = tick;
        }

        private RegexInput _input;
        private DateTime _dateTimeStamp;
        private Double _tick;

        internal RegexInput Input
        {
            get { return _input; }
        }

        internal DateTime DateTimeStamp
        {
            get { return _dateTimeStamp; }
        }

        internal Double Tick
        {
            get { return _tick; }
        }

        internal Double TickInNanoSeconds
        {
            get { return _tick * FieldHelper.NanoSecondPerTick; }
        }
    }
}