using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class Thread3
    {
        int zz = 0;

        int numberOfSeconds;
        /*
        MainThread remain1 = new MainThread();
        MainThread check = new MainThread();*/

        public void T3Function(int timer, int p3)
        {

            Thread t3 = new Thread(() =>
            {
                // int endtime = 0;


                while (numberOfSeconds < p3)
                {


                    Thread.Sleep(1000);
                    //endtime++;
                    numberOfSeconds++;
                    Console.WriteLine("t3");
                    // remain1.T1remaintime(numberOfSeconds);



                }

                Console.WriteLine("t3 Finished");
                zz = 1;
                // check.T1check(0);





                //endtime = 0;

            });

            t3.Start();
            if (zz == 1)
            {
                t3.Abort();
            }







        }
    }
    
}
