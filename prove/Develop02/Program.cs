using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Collections.Generic;

class Program 

{
    static void Main(string[] args)
{
        string begin = "-1";
        Journal journal = new Journal();

        //Journal journal = new Journal("LastVerses");
        //Journal journal2 = new Journal("Martin", "Quintero");

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
                journal._entries.Add(entry);

            }
            else if (begin == "2")
            {
                Console.WriteLine("Display the journal.");
                journal.DisplayJournal();
            }
            else if (begin == "3")
            {
                Console.WriteLine("Reading list from file.");
                Console.Write("Enter the name file txt: ");
                journal._file = Console.ReadLine();
                journal.LoadFile();

            }
            else if (begin == "4")
            {
                Console.WriteLine("Save file");
                Console.Write("Enter the name file txt: ");
                journal._file = Console.ReadLine();
                journal.SaveToFile();
            }
            else 
            {
                Console.WriteLine("have a great day");
            }

        }
    }

}






