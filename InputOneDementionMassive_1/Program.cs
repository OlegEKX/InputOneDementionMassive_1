﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOneDementionMassive_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод элементов массива в строку
            Console.WriteLine("Введите количество элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            
            string[] tempMass = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(tempMass[i]);
            }

            foreach (var item in mas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
