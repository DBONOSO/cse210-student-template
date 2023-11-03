using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string responde = "";

        while (responde !="4")
        {
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu; ");
            string userResponde = Console.ReadLine();
            responde = userResponde;
            int userInput = Console.ReadLine();
            Console.Clear();
            Activity activity = new Activity();

            if (userInput == 1)
            {
                Activity activity1 = new Activity();
                activity1.runActivity(userInput);
            }
            if (userInput == 2)
            {
                Activity activity2 = new Activity();
                activity2.runActivity(userInput);
            }
            if (userInput == 3)
            {
                Activity activity3 = new Activity();
                activity3.runActivity(userInput);
            }

        }
        {
            Console.WriteLine("Thanks for your time");
            Console.WriteLine("");
        }
    }
}