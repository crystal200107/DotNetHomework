using System;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.alarmTime = new Time(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second+3);
            clock.tickEvent += Tick;
            clock.alarmEvent += Alarm;
            clock.LaunchEvent();

            void Tick(Clock sender)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("滴答"+clock.currentTime.Hour+":"+clock.currentTime.Minute+":"+clock.currentTime.Second);
            }

            void Alarm(Clock sender)
            {
                if (clock.currentTime.Equals(clock.alarmTime)) { Console.WriteLine("时间到!"); }
            }
        }
    }
}
