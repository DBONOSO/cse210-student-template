using System;

class Program
{
    static void Main(string[] args)
    {

        string cwd = Directory.GetCurrentDirectory();
        string fileName = "goals.txt";
        string fileString = $"{cwd}/{fileName}";

        string response = "";

        

        while (response != "6")
        {
            Console.WriteLine();
            Points points = new Points();
            int currentPoints = points.getPoints();
            Console.WriteLine($"You currently have {currentPoints} points.");
            Console.WriteLine();
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string userResponse = Console.ReadLine();
            response = userResponse;
            int userInput = int.Parse(response);
            Goals goal = new Goals();

            if (userInput == 1) 
            {
                
                int goalType = 0;
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string userResponse1 = Console.ReadLine();
                goalType = int.Parse(userResponse1);
                if (goalType == 1) 
                {
                    goal.createGoal(goalType, fileString, fileName);
                }
                if (goalType == 2)
                {
                    goal.createGoal(goalType, fileString, fileName);
                }
                if (goalType == 3)
                {
                    goal.createGoal(goalType, fileString, fileName);
                }
                
                
            }
            if (userInput == 2)
            {
                Console.Clear();
                Console.WriteLine("");
                goal.showAllGoals(fileString);
                
            }
            if (userInput == 3) 
            {
                fileName = goal.saveGoals(fileName);
                fileString = $"{cwd}/{fileName}";                
            }
            if (userInput == 4) 
            {
                fileName = goal.loadGoals();
                fileString = $"{cwd}/{fileName}";
            }
            if (userInput == 5)
            {
            }

        }
        {
            Console.WriteLine("Thank you for participating.");
            Console.WriteLine("");
        }
    }
}