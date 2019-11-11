using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    
    public class Thread1
    {
        int numberOfSeconds ;
        int zz = 0;
        MainThread remain1 = new MainThread();
        MainThread check = new MainThread();

        public void T1Function(int timer,int p1)
        {
                
                Thread t1 = new Thread(() =>
                {
                    int endtime = 0;

                    
                    while (numberOfSeconds < p1)
                    {
                        Thread.Sleep(1000);
                        endtime++;
                        numberOfSeconds++;
                        Console.WriteLine("t1");
                        // remain1.T1remaintime(numberOfSeconds) ;
                        check.count1++;





                    }
                   
                        Console.WriteLine("t1 Finished");
                        zz = 1;
                        //check.T1check(0);
                    




                   // endtime = 0;
                    
                });

                t1.Start();
                if (zz==1)
                {
                        t1.Abort();
                }
                
            
                
                

            
            
        }
       
    }
}
