using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RealTime2
{
    public class Clock
    {
        private int hour;
        private int min;
        private int sec;
        public delegate void SecondHasChangedHandler(object clock, TimeInfoEventArgs timeInfo);
        public event SecondHasChangedHandler SecondChanged;
        public void Run()
        {
            for(; ; )
            {
                Thread.Sleep(1000);
                System.DateTime dt = System.DateTime.Now;
                if(dt.Second !=sec)
                {
                    TimeInfoEventArgs timeInfo = new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second);
                    if(SecondChanged!=null)
                    {
                        SecondChanged(this, timeInfo);
                    }
                }
            }
        }
    }
}
