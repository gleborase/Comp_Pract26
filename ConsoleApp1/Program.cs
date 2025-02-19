using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {/// <summary>
     /// 1) Заполнить одномерный массив из n элементов с клавиатуры и вывести его на экран.
     /// </summary>
        static void Main(string[] args)
        {
            int[] omas = new int[Input()];
            ArrayFilling(omas);
            ArrayPrinting(omas);
            Console.Read();
        }

        static int Input()
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }

        static void ArrayFilling(int[] omas)
        {
            for (int i = 0; i < omas.Length; i++)
            {
                Console.Write($"arr[{i}]= ");
                omas[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void ArrayPrinting(int[] omas)
        {
            for (int i = 0; i < omas.Length; i++)
            {
                Console.WriteLine($"arr[{i}]={omas[i]}");
            }
        }
    }

}      
