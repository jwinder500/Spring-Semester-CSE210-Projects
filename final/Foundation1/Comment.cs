using System;

namespace Foundation1
{
    public class Comments
    {
        private List<string> names = new List<string>();
        private List<string> text = new List<string>();
        public void AddComment(string name1, string text1)
        {
            names.Add(name1);
            text.Add(text1);
        }
        public void PrintComments()
        {
            for (int i = 0; i<names.Count; i++)
            {
                Console.Write(names[i]);
                Console.Write($": {text[i]}");
                Console.WriteLine();
            }
        }
    }
}