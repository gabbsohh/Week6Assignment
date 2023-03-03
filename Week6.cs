using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Assignment
{
    internal class Week6
    {
        static void Main(string[] args)
        {
            //call methods
            problemOne();
            Console.WriteLine("------------------------");
            problemTwo();
        }

        //problemOne: write a program and continuously ask user to enter diff names, until user presses enter (w/o supplying name)
        //based on number of names provided, display message similar to FB. USE LIST
        static void problemOne()
        {
            string input = "";

            List<string> names = new List<string>();

            //use a do while loop
            do
            {
                //user input and assigning input to variable
                Console.WriteLine("Enter a name or press 'Enter' to quit: ");
                input = Console.ReadLine();

                names.Add(input);

            } while (input != "");

            //displaying who likes post
            if (names.Count == 1)
            {
                Console.WriteLine("");
            }

            else if (names.Count == 2)
            {
                Console.WriteLine(names[0] + " likes your post");
            }

            else if (names.Count == 3) {
                Console.WriteLine(names[0] + " and " + names[1] + " like your post.");
            }

            else {
                //not sure why it has it subtract by 3, but works
                int others = names.Count - 3;
                Console.WriteLine(names[0] + " and " + names[1] + " and " + others + " others" + " like your post.");
            }

        }

        //problemTwo: write a program to asking user to enter a sentence. Display each unique letter in the sentence and how many times it appeared
        //USE DICTIONARY
        static void problemTwo() 
        { 
            //has to be char for each letter, and int to keep count of letter repetition
            Dictionary<char, int> sentence = new Dictionary<char, int>();
            string input = "";

            Console.WriteLine("Enter a sentence: ");
            input = Console.ReadLine();

            foreach (char letter in input)
            {

                if (char.IsLetter(letter))
                {
                    if (sentence.ContainsKey(letter))
                    {
                        sentence[letter]++;
                    }
                    else
                    {
                        sentence[letter] = 1;
                    }

                }
            }
            //display
            foreach (KeyValuePair<char, int> kvp in sentence)
            {
                Console.WriteLine(kvp.Key + " | " + kvp.Value);
            }

        }

    }
}
