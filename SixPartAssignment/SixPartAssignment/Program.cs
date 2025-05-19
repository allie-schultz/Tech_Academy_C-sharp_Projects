using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            string[] Array1 = { "Hello ", "My ", "The " };
            Console.WriteLine("Inpute a string of text:");
            string input = Console.ReadLine();

            for (int i = 0; i < Array1.Length; i++)
            {
                Array1[i] = Array1[i] + input;
            }
            Console.WriteLine("Updated Array:");
            foreach (string newString in Array1)
            {
                Console.WriteLine(newString);
            }
            ////Console.ReadLine();

            //Part 2
            bool isTrue = true;
            while (isTrue)
            {
                Console.WriteLine("\nHello");
                isTrue = false;
            }
            Console.ReadLine();

            //Part 3
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i is equal to: " + i);
            }
            Console.ReadLine();
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("i is equal to: " + i);
            }
            Console.ReadLine();

            //Part 4
            List<string> stringList = new List<string>
            {  
                "sky",
                "mountain",
                "river",
                "forest",
                "ocean",
                "desert"
            };
            Console.Write("Enter text to search for in the list: ");
            string UserSearch = Console.ReadLine();

            bool matchFound = false;
            int index = -1;

            for (int i = 0; i < stringList.Count; i++)
            {
                if (stringList[i].Contains(UserSearch))
                {
                    matchFound = true;
                    index = i;
                    break;
                }
            }

            if (!matchFound)
            {
                Console.WriteLine("No match found for the text " + UserSearch );
            }
            else
            {
                Console.WriteLine("Match found at index: " + index);
            }
            Console.ReadLine();

            //Part 5
            List<string> stringList2 = new List<string>
                {
                "sky",
                "mountain",
                "river",
                "forest",
                "ocean",
                "river",
                "desert"
            };
            Console.Write("Enter text to search for in the list: ");
            string ListSearch = Console.ReadLine();

            bool match = false;

            for (int i = 0; i < stringList2.Count; i++)
            {
                if (stringList2[i].Contains(ListSearch))
                {
                    Console.WriteLine("Match found at index: " + i);
                    match = true;
                }
            }

            if (!match)
            {
                Console.WriteLine("No match found for the text " + UserSearch);
            }
            else
            {
                Console.WriteLine("All matching occurences have been listed");
            }
            Console.ReadLine();

            //Part 6
            List<string> stringList3 = new List<string>
                {
                "sky",
                "mountain",
                "river",
                "forest",
                "ocean",
                "river",
                "desert"
            };

            HashSet<string> encounteredStrings = new HashSet<string>();

            foreach (string currentString in stringList3)
            {
                if (encounteredStrings.Contains(currentString))
                {
                    Console.WriteLine("Duplicate found: " + currentString);
                }
                else
                {
                    Console.WriteLine("No duplicate found: " + currentString);
                    encounteredStrings.Add(currentString);
                }
            }
            Console.ReadLine();

        }
    }
}
