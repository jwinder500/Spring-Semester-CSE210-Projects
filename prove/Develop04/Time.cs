using System;

namespace Develop04
{
    public class Timer
    {
        //This class hass all animations related to time
        
        public void countdown(int integer)
        {
            
            //counts down from 5
            for (int i = integer; i > 0 ; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        public void dotdotdot(int integer)
        {
            //adds dots for specified time
            for (int i = integer; i > 0 ; i--)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
        }

        private List<string> spin = new List<string>
        {
            //spinner list
            "|",
            "/",
            "-",
            "\\",
        };

        public void spinner()
        {
            
            //spinner animation
            foreach (string s in spin)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}