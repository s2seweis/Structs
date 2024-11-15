using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs.MathClassExample
{
    internal class MathE
    {
        public MathE()
        {
            MathEMethod();
        }

        private void MathEMethod()
        {
            // So even if 15.3 usually wouldn't be sealed it's below 0.5, it still is being sealed here 
            // So that's how you can rund up a value, for get the next full number  
            Console.WriteLine("Ceiling:" + Math.Ceiling(15.3));
            // So to get the next lower full number
            Console.WriteLine("Floor:" + Math.Floor(15.3));

            int num1 = 13;
            int num2 = 9;

            // We get the lower valuve of these two numbers
            Console.WriteLine("Lower of num1 {0} and num2 {1} is {2}", num1, num2, Math.Min(num1, num2));
            // We get the higher valuve of these two numbers
            Console.WriteLine("Higher of num1 {0} and num2 {1} is {2}", num1, num2, Math.Max(num1, num2));
            // Square a number 
            Console.WriteLine("3 to the power of 5 is {0}", Math.Pow(3, 5));
            // For use PI
            Console.WriteLine("PI is: {0}", Math.PI);
            // Calculate the square root
            Console.WriteLine("The square root of 25 is {0}", Math.Sqrt(25));
            // Always return a positive number
            Console.WriteLine("Always positive is {0}", Math.Abs(-25));
            // Calculate cos
            Console.WriteLine("cos of 1 is: {0}", Math.Cos(1));

        }
    }
}

// Math class has plenty of methods