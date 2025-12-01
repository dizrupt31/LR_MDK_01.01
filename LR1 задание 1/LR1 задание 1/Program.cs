using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1_задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Бородин Вариант_2 Задание_1
            Console.WriteLine("Введите размер массива: ");
            int lengthArray = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[lengthArray];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < lengthArray; i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}