using System;

namespace Triangels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle #1");
            {
                int val = 5;
                for (int i = 1; i <= val; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("Triangle #2");
            {
                int val = 5;
                for (int i = 1; i <= val; i++)
                {
                    for (int j = 1; j <= val - i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("*");
                }
            }

            Console.WriteLine("Pyramid");
            {
                int i, j, k, value = 20;
                for (i = 1; i <= value; i++)
                {
                    for (j = 1; j <= value - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (k = 1; k <= i; k++)
                    {
                        Console.Write(" *");
                    }
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("İnverted Pyramid");
            {
                int i, j, k, value = 20;
                for (i = 0; i <= value; i++)
                {
                    for (j = 0; j <= i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (k = 1; k <= value - i; k++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("Triangle with Numbers");
            {
                int num1 = 1;
                int val = 5;
                for (int i = 1; i < val; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write($" {num1++}");
                    }
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("Input the terms or numbers");
            int num2 = int.Parse(Console.ReadLine());

            string num3 = "9";
            string sum2 = "";
            for (int i = 1; i <= num2; i++)
            {
                sum2 += num3;
                Console.WriteLine(sum2);
            }
            // output 9 99 999 9999 99999
        }

    }
}
