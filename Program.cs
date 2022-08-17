using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] PhoneBook = { "Paul Smith - 380635555154", "Steve James - 380677777174", "Victor Rice - 380508888184" };

            int counter; 
            List<string> result = new List<string>();
            Console.WriteLine("Enter name/surname or phone number to search:\n");

            string answer = Console.ReadLine();
            Regex regex = new Regex(answer);

            foreach (var contact in PhoneBook)
            {
                MatchCollection matches = regex.Matches(contact);
                counter = matches.Count;
                if (matches.Count > 0)
                {
                    result.Add(contact);
                }
            }
            if (result.Count > 0)
            {
                Console.WriteLine("Matches:");
                foreach (var person in result)
                {
                    Console.WriteLine(person);
                }
            }
            else
            {
                Console.WriteLine("Error #23432: contact not found!");
            }

        }
        
          
    }
}


