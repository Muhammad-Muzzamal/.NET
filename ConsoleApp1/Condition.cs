using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Condition
    {
        public void isAdult(int age)
        {
            if(age >= 18)
            {
                Console.WriteLine("You are adult");
                return;
            } 
            Console.WriteLine("You are kids");
            return;
            
        }

        public void Day()
        {
            Console.Write("Enter a number day : ");
            int day = Convert.ToInt32(Console.ReadLine());
            
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tusday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thurday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid Day");
                    break;

            }
        }
    }
}
