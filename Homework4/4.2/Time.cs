using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class Time
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
            if (!(Judge())) { throw new ArgumentOutOfRangeException(); }
        }

        public override bool Equals(object obj)
        {
            return obj is Time time &&
                   Hour == time.Hour &&
                   Minute == time.Minute &&
                   Second == time.Second;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hour, Minute, Second);
        }

        public bool Judge()
        {
            if (Hour<0||Hour>24||Minute<0||Minute>60||Second<0||Second>60) { return false; }
            else { return true; }
        }


    }
}
