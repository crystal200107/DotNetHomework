using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class Clock
    {
        public Time currentTime { get; set; }
        public Time alarmTime { get; set; }

        public event Action<Clock> alarmEvent;

        public event Action<Clock> tickEvent;

        public void LaunchEvent()
        {
            while (true)
            {
                currentTime = new Time(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                tickEvent(this);
                alarmEvent(this);
            }
        }
    }
}
