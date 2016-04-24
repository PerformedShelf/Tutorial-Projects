using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("What is your name?");

            /*string myFirstName;
            Console.Write("Type your first name: ");
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.Write("Type your last name: ");
            myLastName = Console.ReadLine();*/

            Console.Write("Type your first name: ");
            string myFirstName = Console.ReadLine();
        
            Console.Write("Type your last name: ");
            string myLastName = Console.ReadLine();
            
            Console.WriteLine("Hello, " + myFirstName + " " + myLastName + ". How are you feeing today? ");

            Console.Write("Type your current mood (good or bad): ");
            string myCurrentMood = Console.ReadLine();

            if (myCurrentMood == "good")
            {
                Console.WriteLine("I am glad you are feeling " + myCurrentMood + " " + myFirstName + ". Have you had a nice day?");

                Console.Write("Type your response: ");
                string moodResponse = Console.ReadLine();

                Console.WriteLine("May the rest of your day be equally as good! :D");
            }
           
            else if (myCurrentMood == "bad")
            {
                Console.WriteLine("I am sorry you are feeling " + myCurrentMood + " " + myFirstName + ". Has it been a tough day?");

                Console.Write("Type your response: ");
                string moodResponse = Console.ReadLine();

                Console.WriteLine("I hope the rest of your day is not as bad! :)");
            }
        
         
            Console.ReadLine();

            
        }
    }
}
