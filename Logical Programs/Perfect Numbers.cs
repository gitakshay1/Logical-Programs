using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Perfect_Numbers
    {
        public void PerfectNumbers()
        {
            Console.WriteLine("Enter Number :");
            int Num=Convert.ToInt32(Console.ReadLine());
            int Sum = 0;
            for(int i=1;i<=Num/2;i++)
            {
               if(Num%i==0)
                {
                   Sum=Sum+i; 
                }
            }
            if(Sum==Num)
            {
                Console.WriteLine(Num + "is Perfect Number");
            }
            else
            {
                Console.WriteLine(Num + " is not Perfect Number");
            }
        }
    }
}
