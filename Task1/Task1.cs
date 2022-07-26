// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

using System;

namespace Homework9
{
    class Task1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int N = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите M: ");
            int M = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine($"N={N}, M={M}");

            Solution (M,N);
        }
        static void Solution (int N, int M)
        {
            if (M > N)
                for (int i = N; i <= M; i++)
                    Console.Write($" {i}");
            else
                for (int i = M; i <= N; i++)
                    Console.Write($" {i}");
        }
    }
}