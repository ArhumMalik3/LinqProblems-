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

            // Problem 3: Using LINQ, write a function that calculates the class grade average after dropping the lowest grade for each student. 
           
            List<string> classGrades = new List<string>()   {
                                                            "80,100,92,89,65",
                                                            "93,81,78,84,69",
                                                            "73,88,83,99,64",
                                                            "98,100,66,74,55"
                                                            };
            double cumulativeTotal = 0;
            foreach (string s in classGrades)
            {
                string[] grades = s.Split(','); 
                var gradesNumber = grades.Select(g => Int32.Parse(g)).ToList();
                gradesNumber.Remove(gradesNumber.Min()); 
                cumulativeTotal += gradesNumber.Average(); 

            }
            var Total = cumulativeTotal / classGrades.Count;

            Console.WriteLine(Total);


            // Problem 4: Write a function that takes in a string of letters (i.e. “Terrill”) 
            // and returns an alphabetically ordered string corresponding to the letter frequency (i.e. "E1I1L2R2T1")

            string letters = "Terrill";
            var lettersCombined = new StringBuilder();
            string organizedLetters = letters.ToUpper();
            char[] a = organizedLetters.ToCharArray();
            Array.Sort(a);
            foreach (char c in a)
            {
                if (a != null)
                {
                    if (a.Count(letter => letter == c) == 0)
                    {
                        continue;
                    }
                    else
                    {
                        lettersCombined.Append(c);
                        lettersCombined.Append(a.Count(letter => letter == c));
                        char[] temp = a.Where(letter => letter != c).ToArray();
                        a = temp;
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(lettersCombined);
            Console.ReadLine();
        }
    }
}
