using System;
using System.ComponentModel.Design;

class Program 
{
    static void Main(string[] args)
{
    string begin = "-1";

        while (begin != "5")
        {
            Prompt prompt = new Prompt();
            Console.Write("Jornal Menu");
            Console.Write("\n" +
            "\n 1. Write" +
            "\n 2. Display" +
            "\n 3. Load" +
            "\n 4. Save" +
            "\n 5. Quit");
            string select = Console.ReadLine();
            Console.Write("What would you like to do? ");

            if (select == "1")
            {
                string listQuestion = prompt.PromptGenerator();
                
            }




        }
    }

}






