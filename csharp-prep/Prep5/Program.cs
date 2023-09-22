using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;



DisplayWelcome();

string userName = PromptUserName();
int userNumber = PromptUserNumber();
int squaredNumber = SquareNumber(userNumber);

DisplayResult(squaredNumber, userName);

static void DisplayWelcome()
{
    Console.WriteLine("Welcome to the Program!");
}
static string PromptUserName()
{
    Console.Write("Please enter your name: ");
    string Response = Console.ReadLine();
    return Response;
}
static int PromptUserNumber()
{
    Console.Write("Please enter your favorite number: ");
    int Response = int.Parse(Console.ReadLine());
    
    return Response;

}
static int SquareNumber(int user)
{
    int sum = user * user;
    return sum;
}
static void DisplayResult(int number, string name)
{
    Console.WriteLine($"{name}, the square of your number is {number}");


}


