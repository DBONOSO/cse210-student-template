using System;
using Library_demo;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetName("Bonoso");
        assignment1.SetTopic("Economy");

        Console.WriteLine(assignment1.GetSummary());

        MathAssignments assignments2 = new MathAssignments();
        assignments2.SetName("Section 7.3");
        assignments2.SetTopic("Problems 8-19");
        assignments2.SetMaths("David");

        Console.WriteLine(assignments2.GetSummary());

    }
}