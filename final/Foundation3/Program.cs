using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("___________________________________");
        Address address1 = new Address("Santiago del Estero 53 south");
        Reception reception1 = new Reception("Reception David", "the best reception", "07/12/2023", "11:30", address1, "Reception");
        reception1.AddEmails(new string[] { "david.bonoso21@gmail.com", "moraalima@hotmail.com", "ezelucero@gmail.com" });
        reception1.DisplayShortDeets();
        reception1.DisplayStandardDeets();
        reception1.DisplayFullDeets();
        Console.WriteLine("___________________________________");


        Console.WriteLine("___________________________________");
        Address address2 = new Address("mitre 138 oeste");
        Lecture lecture1 = new Lecture("Matias Sanchez",50,"Bishop's interview", "Come follow me","06/12/2023", "10:00AM", address2, "Interview");
        lecture1.DisplayShortDeets();
        lecture1.DisplayStandardDeets();
        lecture1.DisplayFullDeets();
        Console.WriteLine("___________________________________");

        Console.WriteLine("___________________________________");
        Address address3 = new Address("mitre 178 oeste");
        Gathering gathering1 = new Gathering("Health", "Castillo's clinic", "Take your turn","10/12/2024", "8:00PM", address3, "Consulting");
        gathering1.DisplayShortDeets();
        gathering1.DisplayStandardDeets();
        gathering1.DisplayFullDeets();
        Console.WriteLine("___________________________________");

    }
}