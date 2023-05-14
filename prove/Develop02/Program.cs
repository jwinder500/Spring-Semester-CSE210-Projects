using System.Collections.Generic;
using System;

namespace Develop02{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 6;
            Journal journal = new Journal();

            while (number != 0)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("0. Leave");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display prompts");

                string num = Console.ReadLine();
                number = Int16.Parse(num);

                if (number == 1)
                {
                    Prompt prompt = new Prompt();
                    string NewPrompt = prompt.SelectRandomPrompt();
                    Console.WriteLine($"{NewPrompt}");

                    Entry yourEntry = new Entry();
                    yourEntry.StorePrompt(NewPrompt);
                    string response = yourEntry.GetResponse();
                    yourEntry.StorePrompt(response);
                    string date = yourEntry.GetDate();
                    yourEntry.StoreDate(date);

                    journal.StoreEntry(yourEntry);
                    journal.entries.Add(yourEntry);
                }

                if (number == 2)
                {
                    List<Entry> entries = journal.entries;
                    foreach (Entry entry in entries)
                    {
                        string message
                            = $"{entry.GetDate()}\n{entry.GetPrompt()}\n{entry.GetResponse()}";
                        Console.WriteLine(message);
                    }
                }
            }
        }
    }  
}