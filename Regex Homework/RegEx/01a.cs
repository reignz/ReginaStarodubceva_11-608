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
            string patterns = @"^(0|(0.[0-9]*[1-9])|([+-]0.[0-9]*[1-9])|([1-9]+[0-9]*)|([+-][1-9]+[0-9]*)|(0,0*[(](([1-9]+0*[1-9]+)*|([1-9]+)))[)]|([+-]0,0*[(](([1-9]+0*[1-9]+)*|([1-9]+))[)]))$";
            Regex a = new Regex(patterns);
            string number = Console.ReadLine();

            if (a.IsMatch(number))
                    Console.WriteLine("Число удовлетворяет условию");
                else Console.WriteLine("Число не удовлетворяет условию");
            Console.ReadKey();
        }
    }
}
