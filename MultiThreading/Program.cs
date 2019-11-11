using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------
           
            //---------------------------------------
            int pmain=0;
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            Console.WriteLine("Please insert period of time:\n  ");
            pmain = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert the 1st service time:  ");
            p1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert the 2st service time:  ");
            p2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert the 3st service time:  ");
            p3 = Convert.ToInt32(Console.ReadLine());
            MainThread s1 = new MainThread();
            s1.StartMultiThreading(pmain,p1,p2,p3);
            Console.ReadLine();

           // Console.WriteLine("HelloWorld");
        }
    }
}
