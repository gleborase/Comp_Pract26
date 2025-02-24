using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{/// <summary>
/// 4) Заполнить одномерный массив, используя явную инициализацию, и вывести индексы элементов, больших заданного числа.
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] omas = new int[5];
            for (int i = 0; i < omas.Length; i++)
            {
                omas[i] = random.Next();
            }
            Console.Write("mas:");
            foreach (int item in omas)
            {
                Console.Write(item + " ");
            }
            Console.Read();
        }
    }
}
