using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World from main main");
            //Class1 obj = new Class1();
            //obj.Show();

            // variable declaration and initialization

            int age = 21;
            double height = 6.0;
            char grade = 'A';
            bool isStudent = true;

            // Printing the variables
            //Console.WriteLine("Age : " + age);
            //Console.WriteLine("Height : " + height);
            //Console.WriteLine("Grade : " + grade);
            //Console.WriteLine("isStudent : " + isStudent);

            // input from user
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.Write("What is your favorite color?");
            //string color = Console.ReadLine();

            //Console.WriteLine("Hello I am " + name + " and my favorite color is " + color);

            Math math = new Math();
            // math.PerformArithematicOperations();
            // math.PerformLogicalOperations();

            Loops loops = new Loops();
            // loops.ForLoop();
            // loops.WhileLoop();
            //loops.Table();

            ReadNumber rn = new ReadNumber();
            //rn.ReadValues1();
            //rn.ReadValues();

            Condition c = new Condition();
            //c.Day();

            Array a = new Array();
            //a.func1();

            Student std = new Student("Muhammad MUzzamal", 12);
            //Console.WriteLine(std.Name);

            Test t = new Test();


        }

        
    }
}