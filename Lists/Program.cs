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
            string upperReadLine;
            List<string> names = new List<string>() { "Arthur Dent", "Marvin" };
            names.Add("Trillian");
            names.Add("Ford Prefect");
            for (int i = 0; i < names.Count; i++)
                names[i] = names[i].ToUpper();

            for (int p = 0; p < names.Count; p++)
                Console.WriteLine(names[p]);

            Console.WriteLine("");

            names.Sort();

            foreach (string name in names) 
                Console.WriteLine(name);

            Console.WriteLine("");

            Console.WriteLine("Please add 3 new names");
            for (int i = 0; i < 3; i++)
                names.Add(Console.ReadLine().ToUpper());

            Console.WriteLine("");

            names.Sort();

            foreach (string name in names)
                Console.WriteLine(name);
            Console.WriteLine($"In this list there are {names.Count} names");

            Console.WriteLine("");

            Console.WriteLine("Please enter a name to remove it from the list");
            upperReadLine = Console.ReadLine().ToUpper();
            if (names.Remove(upperReadLine))
                Console.WriteLine($"{upperReadLine} deleted");
            else
            {
                names.Add(upperReadLine);
                Console.WriteLine($"{upperReadLine} added");
            }

            Console.WriteLine("");

            foreach (string name in names)
                Console.WriteLine(name);
            Console.WriteLine($"In this list there are {names.Count} names");

            Console.WriteLine("");


            Console.WriteLine("Press enter to quit");
            Console.ReadLine(); 
        }
    }
}
