using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UppgifterFrånPresentationer
{
    public class Event
    {
        public event EventHandler firstEvent;
        public void Interval()
        {          
            if (firstEvent != null)
            {
                firstEvent(this, EventArgs.Empty); // call firstevent  
            }            
        }        
    }

    public class Loop
    {
        public event EventHandler secondEvent;
        public void LoopMethod(object source, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(2 * 1000);
                if (secondEvent != null)
                {
                    secondEvent(this, EventArgs.Empty); // call secondevent  
                }
            }
        }
    }
    public class Print
    {
        public void PrintMethod(object source, EventArgs e)
        {
            Console.WriteLine("Run, wait, run...............");
        }
    }
}
