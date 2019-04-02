using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grouping
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "barev axpers vonc es inch ka";
            Group(text);
        }

        static void Group(string text)
        {
            string[] splitedText = text.Split(' ');
            var result = splitedText.OrderBy(x => x.Length)
                .Select(x=> x)
                .ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

    }
}
