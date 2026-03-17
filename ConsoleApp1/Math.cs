using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Math
    {
        int a = 10;
        int b = 20;

        public void PerformArithematicOperations()
        {
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            double quotient = (double)a / b;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
        }

        public void PerformLogicalOperations()
        {
            bool isAGreaterThanB = a > b;
            bool isALessThanB = a < b;
            bool isAEqualToB = a == b;
            Console.WriteLine("Is A greater than B? " + isAGreaterThanB);
            Console.WriteLine("Is A less than B? " + isALessThanB);
            Console.WriteLine("Is A equal to B? " + isAEqualToB);
        }

    }
}
