using System.Collections.Generic;
using System;

namespace Develop02{
    class Program
    {
        static void Main(string[] args)
        {
            //add some test entries
            Entry myEntry = new Entry();
            myEntry.StorePrompt("What is your name?");
            myEntry.StoreResponse("James Winder");
            myEntry.StoreDate("8 May 2023");

            //add some test entries
            Entry yourEntry = new Entry();
            yourEntry.StorePrompt("What is your favorite food?");
            yourEntry.StoreResponse("Penut Butter");
            yourEntry.StoreDate("8 May 2023");

            //Create journal to test
            Journal journal = new Journal();
            journal.StoreEntry(myEntry);
            journal.StoreEntry(yourEntry);

            //Show the journal contents
            List<Entry> entries = journal.GetEntries();
            foreach (Entry entry in entries)
            {
                string message
                    = $"{entry.GetDate()}\n{entry.GetPrompt()}\n{entry.GetResponse()}";
                Console.WriteLine(message);
            }
        }
    }  
}