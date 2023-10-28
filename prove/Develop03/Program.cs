using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        scripture.Display();
        string responde = "";

        while(responde != "quit")
        {
            Console.WriteLine("Press enter to continue or type quit to finish.");
            string userResponse = Console.ReadLine();
            responde = userResponse;
            scripture.deleteOneWord();
            Console.Clear();
            scripture.Display();
            if (scripture.checkHidden() == true)

            {
                Console.WriteLine("Congratulations, you finished");
                responde = "quit";
            }
        }
    }
}