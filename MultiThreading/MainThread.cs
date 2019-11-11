using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class MainThread
    {

        int RT1;
        int rts=0;
        public int count1 = 0;
        public int count2 = 0;
        public int count3 = 0;
        DateTime time;
        public void T1remaintime(int RT)
        {
            RT1 = RT;
            
        }
        public void T1check( int s)
        {
            
            rts = s;
        }
        public void StartMultiThreading(int period,int p1 , int p2, int p3)
        {

            Thread1 t1 = new Thread1();
            Thread2 t2 = new Thread2();
            Thread3 t3 = new Thread3();
            int a = 0;



            int max= Math.Max(p1, p2);
            max = Math.Max(max, p3);
            int round = max / period + 1;

            //time = DateTime.Now;
            while (a<round)
            {

                t1.T1Function(period, p1);
                Thread.Sleep(period * 1000);                
                t2.T2Function(period, p2);
                Thread.Sleep(period * 1000);
                t3.T3Function(period, p3);
                Thread.Sleep(period * 1000);
                a++;

            }


            



            Console.WriteLine("main done");

        }
    }
}
