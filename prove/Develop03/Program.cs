using System;
using System.Collections.Generic;

namespace Develop03
{
    public class Program
    {
        static void Main(string[] args)
        {
            // This class puts all other classes together in a loop
            Word scripture = new Word();
            List<string> wordlist = scripture.SplitWords();
            Refrence refrence = new Refrence();
            string stringRefrence = refrence.getRefrence(wordlist);
            string input = "2";

            Console.WriteLine("How many words would you like to start removing?(1-5)");
            string wordsremoving = Console.ReadLine();
            int removing = int.Parse(wordsremoving);
            int removingLater = removing;
            
            while (input != "0")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                if (input == "1")
                {
                    removingLater += 1;
                    removing = removingLater;
                }
                while (removing != 0)
                {
                    scripture.HideWords();
                    removing = removing - 1;
                }
                Console.WriteLine($"{stringRefrence}");
                if (input == "2")
                {
                    scripture.RemoveReference();
                }
                scripture.Display();
                Console.WriteLine("");
                Console.WriteLine("If you would like to remove more words press 1");
                Console.WriteLine("If you would like to exit type 0");
                input = Console.ReadLine();
            }
        }
    }
}