using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;

namespace ConsoleApplication46
{
    class Program
    {
        static void Main(string[] args)
        {
            string patterns = @"(/[a-z,0-9])+(/[a-z,A-Z,0-9,_]+.[a-z]+)";
            Regex a = new Regex(patterns);

            var client = new WebClient();
            string page;
            using (var reader = new StreamReader(client.OpenRead("http://wikipedia.org"))) ;
            {
                page = reader.ReadToEnd();
            };

            var maches = a.Matches(page);
            foreach(Match match in maches)
            {
                match.Value.Replace("http://");
                Console.WriteLine(match.Value.Replace("http://"));
            }
        }
    }
}
