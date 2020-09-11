using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new problems().GetWords();
            var wordsWithTH = words.Where(w => w.Contains("th"));
            foreach (var word in wordsWithTH)
            {
                Console.WriteLine(word);
            }

            //Using LINQ, write a function that takes in a list of strings and returns a copy of the list without duplicates.
            //        List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };

            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            var unduplicatedNames = names.Distinct();
            foreach(var name in unduplicatedNames)
            {
                Console.WriteLine(name);
            }

        }
    }
}
