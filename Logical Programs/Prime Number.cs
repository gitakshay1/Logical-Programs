using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Prime_Number
    {
        public void PrimeNumber()
        {
            Console.WriteLine("Enter Number :");
            int Num=Convert.ToInt32(Console.ReadLine());
            int Result = 0;
            if (Num > 2)
            {
                for (int i = 2; i <= Num / 2; i++)
                {
                    if (Num % i == 0 )
                    {
                        Result = 1;
                        break;
                    }
                }

                if (Result==1|| Num == 2 || Num == 1)
                {
                    Console.WriteLine(Num + " is not Prime Number");
                }
                else
                {
                    Console.WriteLine(Num+" is Prime Number");
                }

            }
           
           

        }
    }
}
