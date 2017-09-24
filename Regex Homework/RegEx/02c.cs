using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication48
{
    class Program
    {
        static void Main(string[] args)
        {
            string patterns = @"^(1+|0+|(01)+0|(01)+|(10)+1|(10)+)$";
            Regex a = new Regex(patterns);

            Console.WriteLine("Вводите строки(для выхода введите пустую строку): ");
            string st = "s";
            string[] codes = new string[0];
            while (st.Length > 0)
            {
                st = Console.ReadLine();
                string[] temp = new string[codes.Length + 1];
                for (int j = 0; j < codes.Length; j++)
                {
                    temp[j] = codes[j];
                }
                temp[codes.Length] = st;
                codes = new string[codes.Length];
            }

            Regex regex = new Regex(patterns);
            int index = 0;
            foreach (string str in codes)
            {
                index++;
                if (regex.IsMatch(str))
                    Console.WriteLine(index);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}