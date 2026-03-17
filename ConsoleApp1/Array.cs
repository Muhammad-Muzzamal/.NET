using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    internal class Array
    {
        public void func1()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
