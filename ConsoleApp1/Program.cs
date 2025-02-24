using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{/// <summary>
/// 2) Заполнить одномерный массив случайным образом целыми числами из интервала от -10 до 10, просмотреть значения массива и найти количество четных элементов.
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Input();
            int[] omas = new int[Input()];
            Vvod(omas, n);
            int evenCount = EvenNumbers(omas);
            Console.WriteLine($"Количество чётных элементов: {evenCount}");
            Console.Read();
        }

        static int Input()
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        static void Vvod(int[] omas, int n)
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                omas[i] = random.Next(-10, 10);
                Console.WriteLine($"omas[{i}]={omas[i]}");
            }
        }
        static int EvenNumbers(int[] array)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}