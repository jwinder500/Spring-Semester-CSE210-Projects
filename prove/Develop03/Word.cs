using System;
using System.Collections.Generic;

namespace Develop03
{
    public class Word
    {
        // This class breaks apart words into scritures, and then hides some of them
        // It also increases the amout of words hidden each time
        private List<string> words = new List<string>{};
        private List<string> hiddenWords = new List<string>{};
        Random random = new Random();
        public List<string> SplitWords()
        {
            Scripture newScripture = new Scripture();
            string scripture = newScripture.selectRandomScripture();
            words = scripture.Split(" ").ToList();
            return words;
        }
        public List<string> RemoveReference()
        {
            words.RemoveAt(0);
            words.RemoveAt(0);
            return words;
        }
        public List<string> HideWords()
        {
            hiddenWords = words;
            int randomword = random.Next(hiddenWords.Count);
            while(hiddenWords[randomword] == "_")
            {
                randomword = random.Next(hiddenWords.Count);
            }
            hiddenWords[randomword] = "_";
            words = hiddenWords;
            return hiddenWords;
        }
        public string Display()
        {
            string adjustedWords = string.Join(" ", hiddenWords);
            Console.WriteLine($"{adjustedWords}");
            return adjustedWords;
        }
    }
}