using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Student
    {
        private string name;
        private int age;
        
        // constructor
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // getter and setter
        public string Name
        {
            get { return this.name; }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                } else
                {
                    Console.WriteLine("Invalid Name!");
                }
            }
        } 
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }


    }
}
