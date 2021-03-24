using System;

namespace RealTime2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Clock c = new Clock();
            DisplayClock dc = new DisplayClock();
            dc.Subscribe(c);
            c.Run();
            Inventory inv = new Inventory();
        }
    }
}
