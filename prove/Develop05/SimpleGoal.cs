using System;

class SimpleGoal : Goal
{
    public SimpleGoal()
    {
        
    }

    public override int calculatePoints()
    {
        return _goalPoints;
    }

}