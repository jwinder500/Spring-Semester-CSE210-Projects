using System;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            //This class runs the program

            int input = 0;
            //this allows user to input info later

            Console.WriteLine("Welcome to the mindfulness place.");
            //Welcomes user at start of program

            while (input != 4)
            {
                //this will let the user
                
                Console.WriteLine("Main Menu(Type any number shown that you would like to do)");
                Console.WriteLine("     1. Breathing Exervise");
                Console.WriteLine("     2. Reflecting Exercise");
                Console.WriteLine("     3. Learning Exercise");
                Console.WriteLine("     4. Quit");
                //This menu lets people know what they can do

                string selection = Console.ReadLine();
                input = int.Parse(selection);
                //Changes input

                if (input == 1)
                {
                    Breathing breathing = new Breathing();
                    breathing.runBreathing();
                    //runs breathing activity if the person chooses
                }

                else if (input == 2)
                {
                    
                    Reflecting reflecting = new Reflecting();
                    reflecting.runReflecting();
                    //runs reflecting activity if the person chooses
                }
                else if (input == 3)
                {
                    Listening listening = new Listening();
                    listening.runListening();
                    //runs listening activity if the person chooses
                }
                else if (input == 4)
                {
                    Console.WriteLine("Thanks for coming");
                    //Thanks user for using the program
                }
                else
                {
                    Console.WriteLine("Try a different number");
                    //tells user to use a different number
                }
            }
        }
    }
}