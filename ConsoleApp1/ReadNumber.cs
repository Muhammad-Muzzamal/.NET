using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class ReadNumber
    {
        public void ReadValues()
        {
            int age;
            double height;
            float weight;
            char grade;
            string name;

            Console.Write("Enter your name : ");
            name = Console.ReadLine();

            Console.Write("Enter your age : ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your height : ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your weight : ");
            weight = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter your Grade : ");
            grade = Convert.ToChar(Console.ReadLine());

            this.Print(age, height, weight, grade, name);
        }

        public void ReadValues1()
        {
            int age;
            double height;
            float weight;
            char grade;
            string name;

            Console.Write("Enter your name : ");
            name = Console.ReadLine();

            Console.Write("Enter your age : ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter your height : ");
            height = double.Parse(Console.ReadLine());

            Console.Write("Enter your weight : ");
            weight = float.Parse(Console.ReadLine());

            Console.Write("Enter your Grade : ");
            grade = char.Parse(Console.ReadLine());

            this.Print(age, height, weight, grade, name);

        }
        void Print(int age, double height, float weight, char grade, string name)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}m");
            Console.WriteLine($"Weight: {weight}kg");
            Console.WriteLine($"Grade: {grade}");
        }
    }
}
