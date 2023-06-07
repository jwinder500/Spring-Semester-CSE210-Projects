using System;
using System.Collections.Generic;

namespace Develop04
{
    public class Prompt
    {
        //This class works with lists
        
        private List<string> prompts = new List<string>();
        // Creates list

        public void addPrompts(List<string> promptlist)
        {
            //This function adds to prompts list
            prompts = promptlist;
        }
        
        public void wipePrompts()
        {
            //this function wipes everything from prompts
            foreach (string prompt in prompts)
            {
                prompts.Remove(prompt);
            }
        }

        Random random = new Random();
        // Creates random variable 
        public string selectRandomPrompt()
        {
            //This function selects a random prompt and returns it as a string
            int index = random.Next(prompts.Count);
            string prompt = $"{prompts[index]}";
            return prompt;
        }
    }
}