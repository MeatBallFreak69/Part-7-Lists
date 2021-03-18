using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Arthur Dent", "Marvin" };

            names.Add("Trillian");
            names.Add("Ford Prefect");
            Console.WriteLine(names[0]);
            Console.WriteLine(names[names.Count - 1]);
            names[0] = "Arthur";
            Console.WriteLine(names[0]);
            Console.WriteLine(names[2]);
            Console.ReadLine(); 
        }
    }
}
