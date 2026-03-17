using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Loops
    {
        public void ForLoop()
        {
            for(int i= 1; i <= 5; i++)
            {
                Console.WriteLine("Number : " + i);
            }
        }

        // while loop
        public void WhileLoop()
        { 
            Console.WriteLine("While Loop:");
            int i = 1;
            while(i <= 5)
            {
                Console.WriteLine("Number : " + i);
                i++;
            }
        }

        public void Table()
        {
            Console.Write("Write number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + (number * i));
            }
            return;
        }

    }
}
