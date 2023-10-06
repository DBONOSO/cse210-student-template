using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;

class Program 
{
    static void Main(string[] args)
{
    string begin = "-1";

        while (begin != "5")
        {
            
            Entry entry = new Entry();
            Prompt prompt = new Prompt();
            Console.Write("Jornal Menu");
            Console.Write("\n" +
            "\n 1. Write" +
            "\n 2. Display" +
            "\n 3. Load" +
            "\n 4. Save" +
            "\n 5. Quit" +
            "\n What would you like to do? ");
            
            begin = Console.ReadLine();

            if (begin == "1")
            {
                string listQuestion = prompt.PromptGenerator();
                Console.WriteLine(listQuestion);
                entry._response = Console.ReadLine();
                entry._prompt = listQuestion;
                DateTime date = DateTime.Now;
                entry._date = date.ToShortDateString();

                
            }
            else if (begin == "2")
            {

            }




        }
    }

}






