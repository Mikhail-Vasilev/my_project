﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите a:");
            string a = Console.ReadLine();
            double a1 = Convert.ToDouble(a);

            Console.WriteLine("Введите b:");
            string b = Console.ReadLine();
            double b1 = Convert.ToDouble(b);

            Console.WriteLine("Введите c:");
            string c = Console.ReadLine();
            double c1 = Convert.ToDouble(c);

            double D = Math.Pow(b1, 2) - 4 * a1 * c1;
            Console.WriteLine("{0}^2", D);

            Console.WriteLine("(-b+/-корень D)/2a");
            if (D >=0)
            {

                double one = (-b1 + Math.Sqrt(D)) / (2 * a1);
                double two = (-b1 - Math.Sqrt(D)) / (2 * a1);
                Console.WriteLine("x1={0}\nx2={1}",one,two);
            }
            else
            {
                Console.WriteLine("нет корней");
            }
            Console.ReadKey();
        }
    }
}
