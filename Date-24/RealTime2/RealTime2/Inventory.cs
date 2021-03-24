using System;
using System.Collections.Generic;
using System.Text;

namespace RealTime2
{
    public class Inventory
    {
        public void InventoryHasChanged(object theclock, TimeInfoEventArgs ti)
        {
            Console.WriteLine("{0} :{1}: {2}",
           ti.hour.ToString(), ti.min.ToString(), ti.sec.ToString());
        }
    }
}
