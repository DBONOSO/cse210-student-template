using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Swimming swimming1 = new Swimming("01 Dec 2023","Swimming", 01, 12);
        Cycling cycling1 = new Cycling("09 Octo", "Cycling", 09, 10);
        Running running1 = new Running("27 Sep 2023","Running", 27, 09);

        Activities list = new Activities();
        list._activities.Add(swimming1);
        list._activities.Add(cycling1);
        list._activities.Add(running1);

        list.showActivities();

    }
}