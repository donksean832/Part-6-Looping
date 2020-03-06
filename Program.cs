using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_6_Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //for (int i = 0; i < 10; i = i + 2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();

            for (int i =0; i <= 10; i++)
            {
                Console.Write($"{i},");
            }
            Console.WriteLine();
            for (int i = 0; i <= 50; i = i + 5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for (int i = 99; i >= 55; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            int sum = 0;
            for (int i = 20; i <= 40; i = i + 1)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);



            Console.ReadLine();
        }
    }
}
