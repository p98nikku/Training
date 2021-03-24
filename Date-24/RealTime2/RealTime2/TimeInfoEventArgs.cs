using System;
using System.Collections.Generic;
using System.Text;

namespace RealTime2
{
    public  class TimeInfoEventArgs: EventArgs
    {
        public int hour;
        public int min;
        public int sec;

        public TimeInfoEventArgs(int hour,int min, int sec)
        {
            this.hour = hour;
            this.min = min;
            this.sec = sec;
        }
    }
}
