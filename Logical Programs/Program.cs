using System;

namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 Fibonacci Series \n2 Perfect Number");
            int Ans=Convert.ToInt32(Console.ReadLine());
            switch(Ans)
            {
                case 1:
                    Fibonacci_Series fibonacci_Series=new Fibonacci_Series();
                    fibonacci_Series.Fibonacci();
                    break;
                case 2:
                    Perfect_Numbers perfect_Numbers=new Perfect_Numbers();
                    perfect_Numbers.PerfectNumbers();
                    break; 
                default:
                    Console.WriteLine("Enter valid Number");
                    break;  
            }
        }
    }
}
