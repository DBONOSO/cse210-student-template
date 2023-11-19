using System;

class Goal
{
    protected string _nameQuestion = "What is the name of your goal?";
    protected string _desQuestion = "What is a short description of it?";
    protected string _pointsQuestion = "What is the amount of points associated with this goal?";

    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;
    protected bool _isCompleted = false;

    protected int _bonusPoints;
    protected int _numCompletions = 0;
    protected int _neededCompletions = 0;

    protected string _completionsNeededQuestion = "How many times does this need completed to qualify for a bonus?";
    protected string _bonusQuestion = "What is the bonus for accomplishing it that many times?";

    public Goal()
    {
    }

    public virtual int calculatePoints()
    {
        return _goalPoints;
    }

    public string getNameQuestion()
    {
        return _nameQuestion;
    }

    public string getDesQuestion()
    {
        return _desQuestion;
    }

    public string getPointsQuestion()
    {
        return _pointsQuestion;
    }

    public string getGoalName()
    {
        return _goalName;
    }

    public string getGoalDescription()
    {
        return _goalDescription;
    }

    public int getGoalPoints()
    {
        return _goalPoints;
    }

    public void setGoalName(string goalName)
    {
        _goalName = goalName;
    }

    public void setGoalDescription(string goalDescription)
    {
        _goalDescription = goalDescription;
    }

    public void setGoalPoints(int goalPoints)
    {
        _goalPoints = goalPoints;
    }

    public void addGoal(string fullGoalString, string fileString, string fileName)
    {
        
        File.AppendAllText(fileName, fullGoalString + Environment.NewLine);
        
        

    }

    public bool getCompleted()
    {
        return _isCompleted;
    }

    public virtual void setCompleted(bool isCompleted)
    {
        _isCompleted = isCompleted;
    }

    public string getCompletionsQuestion()
    {
        return _completionsNeededQuestion;
    }

    public string getBonusQuestion()
    {
        return _bonusQuestion;
    }

    public int getBonusPoints()
    {
        return _bonusPoints;
    }

    public void setBonusPoints(int bonusPoints)
    {
        _bonusPoints = bonusPoints;
    }

    public int getNumCompletions()
    {
        return _numCompletions;
    }

    public void setNumCompletions(int numCompletions)
    {
        _numCompletions = numCompletions;
    }

    public int getNeededCompletions()
    {
        return _neededCompletions;
    }

    public void setNeededCompletions(int neededCompletions)
    {
        _neededCompletions = neededCompletions;
    }

}