using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{/// <summary>
/// 3) Заполнить одномерный массив соответствующими индексами и вывести с использованием цикла foreach.
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = new int[10];
            Foreach(omas);
        }
        static void Massiv(int[] omas)
        {
            for (int i = 0; i < omas.Length; i++)
            {
                omas[i] = i;
            }
        }
        static void Foreach(int[] omas)
        {
            Massiv(omas);
            foreach (int value in omas)
            {
                Console.Write(value);
            }
        }      
    }
}
