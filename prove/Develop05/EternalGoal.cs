using System;

class EternalGoal : Goal
{


    public EternalGoal()
    {
        _isCompleted = false;
    }

    public override int calculatePoints()
    {
        return _goalPoints;
    }

    public override void setCompleted(bool isCompleted)
    {
        _isCompleted = false;
    }

}