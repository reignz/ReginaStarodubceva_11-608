﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication51
{
    class Program
    {
        static void Main(string[] args)
        {
            string patterns = @"$?<=[02468]";
            Regex regex = new Regex(patterns);

            int[] array = new int[10];
            Random rand = new Random();
            for(int i = 0;i<10;i++)
            {
                array[i] = rand.Next();
                Console.WriteLine(array[i]);
            }
            string[] numbers = new string[10];
            for(int j=0;j<10;j++)
            {
                numbers[j] = array[j].ToString();
            }

            Console.WriteLine("Поиск чётных чисел...");
            foreach (string str in numbers)
            {
                if (regex.IsMatch(str))
                    Console.WriteLine(str);
            }
        }
    }
}