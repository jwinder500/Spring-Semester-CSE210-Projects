using System;
using System.Collections.Generic;

namespace Develop03
{
    public class Refrence
    {
        //This class holds the refrence
        private string refrence;

        public string getRefrence(List<string> list)
        {
            while (list.Count >= 3)
            {
                list.RemoveAt(list.Count - 1);
            }
            refrence = string.Join(" ", list);
            return refrence;
        }
    }
}