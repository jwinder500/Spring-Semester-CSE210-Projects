using System;
using System.Collections.Generic;

namespace Develop02
{
    ///<summary>
    ///The responsibility of the entry class is to create and store entries
    ///<summary>
    public class Entry
    {
        public string prompt;
        public string response;
        public string day;
        public string GetPrompt()
        {
            Prompt NewPrompt = new Prompt();
            string prompt = NewPrompt.SelectRandomPrompt();
            return prompt;
        }
        public string GetResponse()
        {
            string response = Console.ReadLine();
            return response;
        }
        public string GetDate()
        {
            
            var date = DateTime.Today;
            string day = date.ToString();
            return day;
        }
        public void StorePrompt(string prompt)
        {
            this.prompt = prompt;
        }
        public void StoreResponse(string response)
        {
            this.response = response;
        }
        public void StoreDate(string day)
        {
            this.day = day;
        }
    }
}