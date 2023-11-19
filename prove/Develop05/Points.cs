using System;

class Points
{

    private int _totalPoints = 0;



    public Points()
    {
    }

    public int getPoints()
    {
        return _totalPoints;
    }

    public void setPoints(int points)
    {
        _totalPoints = _totalPoints + points;
    }

}