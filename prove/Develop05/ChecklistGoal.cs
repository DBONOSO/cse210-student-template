using System;

class ChecklistGoal : Goal
{




    public ChecklistGoal()
    {}

    public override int calculatePoints()
    {
        if (_numCompletions == _neededCompletions)
        {
            return _goalPoints + _bonusPoints;
        }
        return _goalPoints;
    }


}