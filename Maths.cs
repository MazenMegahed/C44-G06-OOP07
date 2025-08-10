using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP7
{
    internal static class Maths
    {
        public static int counter { get; set; } = 0;
        public static double Add (double a, double b)
        {
            counter++;
            return a + b; 
        }
        public static double Subtract(double a, double b)
        {
            counter++;
            return a - b; 
        }
        public static double Multiply(double a, double b)
        {
            counter++;
            return a * b; 
        }
        public static double Divide(double a, double b)
        {
            counter++;
            if (b != 0) return a / b;
            else return 0;

        }
        public static double Power(double a, double b)
        {
            counter++;
            return Math.Pow(a, b); 
        }
        public static double Avg(double[]nums)
        {
            double sum = 0;
            foreach (double num in nums) 
            {
                sum += num;
            }
            counter++;
            return sum/nums.Length;
        }
        public static void SHOWOPERATIONSCOUNT()
        {
            Console.WriteLine(  "Operations Count = "+counter);
        }

    }
}
