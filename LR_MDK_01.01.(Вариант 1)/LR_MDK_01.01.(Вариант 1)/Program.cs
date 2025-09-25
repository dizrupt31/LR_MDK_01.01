using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_MDK_01._01._Вариант_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов в массиве:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    sum = sum + array[i]; 
                }
            }
            Console.WriteLine($"Сумма положительных элементов: {sum}");
        }
    }
}




