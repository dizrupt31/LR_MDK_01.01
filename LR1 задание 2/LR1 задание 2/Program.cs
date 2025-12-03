using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1_задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[1990];
            int initValue = 10;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = initValue;
                ++initValue;
            }
            List<int> result = new List<int>();
        }
    }
}