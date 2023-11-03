using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

class BreathingActivity : Activity
{
 private string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
 private string _stratMessage = "Welcome to the Breathing Activity";
 private string _endMessage = "";

 private string _name = "Breathing Activity";
 private int _duration;
 public BreathingActivity(int duration) : base(duration)
 {
  _duration = duration;
 }

 public void runBreathingActivity(int duration)
 {
  Console.WriteLine(_stratMessage);
  Console.WriteLine(_description);
  Activity activity = new Activity();
  activity.setDuration();
  _duration = activity.getDuration();
  DateTime currentTime = DateTime.Now;
  DateTime futureTime = currentTime.AddSeconds(5);

  if (currentTime < futureTime)
  {
    Console.Clear();
    Console.Write("Get ready");
    for (int i = 5; i > 0;i--)
    {
     Console.Write(".");
     Thread.Sleep(1000);
    }
    breathing();
    Console.WriteLine(_wellDone);
    _endMessage = $"You finished {_duration / 100} seconds of breathing.";
    Console.WriteLine(_endMessage);
    Thread.Sleep(5000);
  }
 }
 public void breathing()
  {
    Console.Clear();
    for (int i = (_duration/100) / 5; i>0;i--)
    {
    for (int j = 5; j > 0; j--)
    {
     Console.ForegroundColor = ConsoleColor.Blue;
     Console.WriteLine("\b \b");
     Console.Write(j);
     Thread.Sleep(1000);
     Console.WriteLine("\b \b");
   Console.ForegroundColor = ConsoleColor.White;
  }
  Console.Clear();
  Console.WriteLine("Breathe out");
  for (int k = 5; k > 0; k--)
  {
   Console.ForegroundColor = ConsoleColor.Blue;
   Console.WriteLine("\b \b");
   Console.Write(k);
   Thread.Sleep(1000);
   Console.WriteLine("\b \b");
   Console.ForegroundColor = ConsoleColor.White;
  }
  Console.Clear();
 }
 Thread.Sleep(1000);
 }
}