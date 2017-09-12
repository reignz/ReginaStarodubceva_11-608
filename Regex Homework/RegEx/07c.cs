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
            string patterns = "?([a-z,A-Z,0-9,_]+=([a-z,A-Z,0-9,&]+)+)";
            Regex a = new Regex(patterns);
            var ParamString = a.Split(".")[0].Split('/').Last();
            var Extension = a.Split(".")[1];

            var client = new WebClient();
            string page;
            using (var reader = new StreamReader(client.OpenRead("http://wikipedia.org"))) ;
            {
                page = reader.ReadToEnd();
            };
            var maches = a.Matches(page);

            foreach(Match match in maches)
            {
                var parse = match.Value.Replace("?", "");
                Console.WriteLine("ParamString " + pars);
                foreach(var pair in parse)
                    {
                    var splited = pair.Split('=');
                      
                    }

                var file = match.Value.Replace(@"/\""", "").Split('.');
                Console.WriteLine("Filename " + file[0]);
                Console.WriteLine("Extension " + file[1]);
            }
        }
    }
}
