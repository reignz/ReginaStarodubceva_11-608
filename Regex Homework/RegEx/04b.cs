using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication52
{
    class Program
    {
        static void Main(string[] args)
        {
            string patterns = @"^([2468]+[02468]{3,4})$";
            Regex regex = new Regex(patterns);

            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = rand.Next();
                Console.WriteLine(array[i]);
            }
            string[] numbers = new string[10];
            for (int j = 0; j < 10; j++)
            {
                numbers[j] = array[j].ToString();
            }

            foreach (string str in numbers)
            {
                if (regex.IsMatch(str))
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}

