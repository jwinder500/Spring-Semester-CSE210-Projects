using System;
using System.Collections.Generic;

namespace Develop02
{
    ///<summary>
    ///The responsibility of the entry class is to organize and select random prompts
    ///<summary>
    public class Prompt
    {
        public List<string> prompts = new List<string>
        {
            "What is the best thing you ate today?", 
            "What is the funniest thing that happened to you today?",
            "Did you learn anything interesting recently?",
            "Was there anything that was funnier than usual that you found recently?"
        };
        var random = new Random();
        public string SelectRandomPrompt()
        {
            int index = random.Next(prompts.Count);
            string prompt1 = $"{prompts[index]}";
            return prompt1;
        }
    }
}