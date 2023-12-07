using System;

class Swimming : Activity
{
    private float _laps;
    
    public Swimming(string date, string type, float duration, float laps) : base(date, type, duration)
    {
        _laps = laps;
        _date = date;
        _type = type;
        _duration = duration;
    }
    public override string GetSummary()
    {
        _distance = _laps * 50 / 1000;
        _pace = _duration / _distance;
        _speed = 60 / _pace;
        string summary = ($"{_date} {_type} ({_duration} minutes) - Distance {_distance} miles, Speed {_speed} mph, Pace: {_pace} min per mile");
        return summary;

    }
}