using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter scripture reference and text");
        string input = Console.ReadLine();
        string[] inputParts = input.Split(' ', 2);

        if (inputParts.Length == 2)
        {
            Scripture scripture = new Scripture(inputParts[0], inputParts[1]);
            scripture.Display();
            Console.WriteLine("Press Enter to continue or type 'Quit' to exit.");

            while (!scripture.AllWordsHidden())
            {
                string userInput = Console.ReadLine();

                if (userInput.Equals("quit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                scripture.HideRandomWord();
                scripture.Display();
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid scripture reference and text");
        }
    }
}