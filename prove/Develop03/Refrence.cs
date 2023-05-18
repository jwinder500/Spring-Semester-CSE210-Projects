using System;
using System.Collections.Generic;

namespace Develop03
{
    public class Refrence
    {
        //This class holds the refrence
        private string refrence;
        private List<string> listRefrence = new List<string>();

        public string getRefrence()
        {
            Word newRefrence = new Word();
            listRefrence = newRefrence.SplitWords();
            while (listRefrence.Count() > 2)
            {
                listRefrence.RemoveAt(listRefrence.Count());
            }
            refrence = string.Join(" ", listRefrence);
            return refrence;
        }
    }
}