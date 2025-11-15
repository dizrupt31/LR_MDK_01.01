
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace LR2New_V12
{
    static public class Program
    {
        static void Main(string[] args)
        {
            List<phone> AllPhones = new List<phone>();
            AllPhones.Add(new phone() { brand = "Samsung", model = "A", NumberOfSales = 5321, week = 1 });
            AllPhones.Add(new phone() { brand = "Samsung", model = "B", NumberOfSales = 3030, week = 1 });
            AllPhones.Add(new phone() { brand = "Samsung", model = "C", NumberOfSales = 8745, week = 1 });
            AllPhones.Add(new phone() { brand = "Samsung", model = "A", NumberOfSales = 8642, week = 2 });
            AllPhones.Add(new phone() { brand = "Samsung", model = "B", NumberOfSales = 6070, week = 2 });
            AllPhones.Add(new phone() { brand = "Samsung", model = "C", NumberOfSales = 14430, week = 2 });
            AllPhones.Add(new phone() { brand = "Iphone", model = "A", NumberOfSales = 44283, week = 1 });
            AllPhones.Add(new phone() { brand = "Iphone", model = "B", NumberOfSales = 20425, week = 1 });
            AllPhones.Add(new phone() { brand = "Iphone", model = "C", NumberOfSales = 64423, week = 1 });
            AllPhones.Add(new phone() { brand = "Iphone", model = "A", NumberOfSales = 124653, week = 2 });
            AllPhones.Add(new phone() { brand = "Iphone", model = "B", NumberOfSales = 96000, week = 2 });
            AllPhones.Add(new phone() { brand = "Iphone", model = "C", NumberOfSales = 141899, week = 2 });
            AllPhones.Add(new phone() { brand = "Huawei", model = "A", NumberOfSales = 4283, week = 1 });
            AllPhones.Add(new phone() { brand = "Huawei", model = "B", NumberOfSales = 2435, week = 1 });
            AllPhones.Add(new phone() { brand = "Huawei", model = "C", NumberOfSales = 6423, week = 1 });
            AllPhones.Add(new phone() { brand = "Huawei", model = "A", NumberOfSales = 4653, week = 2 });
            AllPhones.Add(new phone() { brand = "Huawei", model = "B", NumberOfSales = 3210, week = 2 });
            AllPhones.Add(new phone() { brand = "Huawei", model = "C", NumberOfSales = 1287, week = 2 });
            Console.WriteLine ("Введите марку устройства");
            string marka = Console.ReadLine();
        }
    }
}
