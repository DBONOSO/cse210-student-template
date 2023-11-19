using System;

class Goals
{

    private List<Goal> _goalList = new List<Goal>();
    public Goals()
    {
    }

    public void createGoal(int goalType, string fileString, string fileName )
    {
        Goal goal = new Goal();
        Console.WriteLine(goal.getNameQuestion());
        string goalName = Console.ReadLine();
        Console.WriteLine(goal.getDesQuestion());
        string goalDescription = Console.ReadLine();
        Console.WriteLine(goal.getPointsQuestion());
        string goalPointsStr = Console.ReadLine();
        int goalPoints = int.Parse(goalPointsStr);
        goal.setGoalName(goalName);
        goal.setGoalDescription(goalDescription);
        goal.setGoalPoints(goalPoints);
        bool isCompleted = goal.getCompleted();
        string fullGoalString = "";
        if (isCompleted == true)
        {
            fullGoalString = fullGoalString = $"[X],{goalName},{goalDescription},{goalPointsStr}";
        } 
        else 
        {
            fullGoalString = $"[ ],{goalName},{goalDescription},{goalPointsStr}";
        }

        
        goal.addGoal(fullGoalString, fileString, fileName);
        if (goalType == 3)
        {
            Console.WriteLine(goal.getCompletionsQuestion());
            string res = Console.ReadLine();
            int numNeeded = int.Parse(res);
            goal.setNeededCompletions(numNeeded);
            Console.WriteLine(goal.getBonusQuestion());
            string res1 = Console.ReadLine();
            int bonus = int.Parse(res1);
            goal.setBonusPoints(bonus);


        }
        
        
    }

    public string saveGoals(string currentFileName)
    {
        Console.Write("What would you like to name your file?");
        string newFileName = Console.ReadLine();
        File.Move(currentFileName, newFileName);
        return newFileName;
    }

    public string loadGoals()
    {
        Console.Write("What is the name of the file you would like to load?");
        string newFileName = Console.ReadLine();
        return newFileName;

    }

    public void recordEvent(int goalNum)
    {

    }

    public void showAllGoals(string fileString)
    {
        string line;
        using (StreamReader file = new StreamReader(fileString))
        {
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        Thread.Sleep(3000);
    }
}