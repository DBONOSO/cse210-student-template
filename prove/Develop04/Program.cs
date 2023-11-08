using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        string responde = "";
        while (responde != "4")
=======
        string response = "";

        while (response !="4")
>>>>>>> 4bc4c1b94788b3b12a8ade9d88fac9ccfe6d26c2
        {
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
<<<<<<< HEAD
            Console.WriteLine("Select a choice from the menu: ");
            string userResponde = Console.ReadLine();
            responde = userResponde;
            int userInput = int.Parse(responde);
=======
            Console.WriteLine("Select a choice from the menu; ");
            string userResponse = Console.ReadLine();
            response = userResponse;
            int userInput = int.Parse(response);
>>>>>>> 4bc4c1b94788b3b12a8ade9d88fac9ccfe6d26c2
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
<<<<<<< HEAD
        }
        {
            Console.WriteLine("Thanks for your participation");
=======

        }
        {
            Console.WriteLine("Thanks for your time");
            Console.WriteLine("");
>>>>>>> 4bc4c1b94788b3b12a8ade9d88fac9ccfe6d26c2
        }
    }
}