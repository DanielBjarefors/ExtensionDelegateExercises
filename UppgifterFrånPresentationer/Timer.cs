using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;


namespace UppgifterFrånPresentationer
{
    public static class Timer
    {
   
        public delegate void WaitDelegate();
        public static void Interval(WaitDelegate voidMethod, int loops, int waitSec)
        {
            for (int i = 0; i < loops; i++)
            {
                Thread.Sleep(waitSec * 1000);
                voidMethod();
            }
        }
        public static void MyMethod()
        {
            Console.WriteLine("Run, wait, run...............");
        }

    }    
}
