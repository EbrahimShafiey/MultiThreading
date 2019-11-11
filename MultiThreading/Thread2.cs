using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class Thread2
    {
        int zz = 0;

        int numberOfSeconds;
        /*
        MainThread remain1 = new MainThread();
        MainThread check = new MainThread();*/

        public void T2Function(int timer, int p2)
        {

            Thread t2 = new Thread(() =>
            {
               // int endtime = 0;


                while (numberOfSeconds < p2)
                {
                    

                        Thread.Sleep(1000);
                        //endtime++;
                        numberOfSeconds++;
                        Console.WriteLine("t2");
                       // remain1.T1remaintime(numberOfSeconds);

                   

                }

                Console.WriteLine("t2 Finished");
                zz = 1;
               // check.T1check(0);





                //endtime = 0;

            });

            t2.Start();
            if (zz == 1)
            {
                t2.Abort();
            }







        }
    }
}
