using System;
using System.Collections.Generic;
using System.Text;

namespace RealTime2
{
    public class DisplayClock
    {
        public void Subscribe(Clock theclock)
        {
            theclock.SecondChanged += new Clock.SecondHasChangedHandler(TimeHasChanged);
        }
        public void TimeHasChanged(object theclock, TimeInfoEventArgs ti)
        {
            Console.WriteLine("Current time : {0} :{1}: {2}",
            ti.hour.ToString(), ti.min.ToString(), ti.sec.ToString());
        }
    }
}
