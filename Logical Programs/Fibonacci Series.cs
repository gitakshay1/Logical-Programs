using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Fibonacci_Series
    {
        public void Fibonacci ()
        {
            Console.WriteLine("Enter the Range of Fibonacci series :");
            int Range=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First term of series :");
            int FirstTerm=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second term of series :");
            int SecondTerm=Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<=Range; i++)
            {
                int ThirdTerm = FirstTerm + SecondTerm;
                Console.WriteLine(ThirdTerm);
                FirstTerm = SecondTerm;
                SecondTerm = ThirdTerm;
            }
        }
    }
}
