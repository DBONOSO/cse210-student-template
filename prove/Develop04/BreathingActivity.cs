using System;

class BreathingActivity : Activity
{
   private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
   private string _startMessage = "Welcome to the listing activity";
   private string _endMessage = "";
   private string _name = "Breathing Activity";
   private int _duration;
   public BreathingActivity(int duration) : base(duration)
   {
    _duration = duration;
   }

   public void runBreathingActivity(int duration)
   {
    Console.WriteLine(_startMessage);
    Console.WriteLine(_description);
    Activity activity = new Activity();
    activity.setDuration();
    _duration = activity.getDuration();
    DateTime currentTime = DateTime.Now;
    DateTime futureTime = currentTime.AddSeconds(5);

    if(currentTime < futureTime)
    {
     Console.Clear();
     Console.Write("Get ready");
     for (int i = 5; i > 0; i--)
     {
       Console.Write(".");
       Thread.Sleep(1000);
     }
     breathing();
     Console.WriteLine(_wellDone);
     _endMessage = $"You finished {_duration / 100} seconds of breathing";
     Console.WriteLine(_endMessage);
     Thread.Sleep(5000);
    }
   }
 public void breathing()
 {
  Console.Clear();
  for (int j = 5; j > 0; j--)
  {
     Console.ForegroundColor = ConsoleColor.Blue;
     Console.Write("\b \b");
     Console.ForegroundColor = ConsoleColor.White;
  }
  Console.Clear();
  Console.WriteLine("Breathe out");
  for (int k = 5;k > 0; k--)
  {
     Console.ForegroundColor = ConsoleColor.Blue;
     Console.Write("\b \b");
     Console.ForegroundColor = ConsoleColor.White;
  }
  Console.Clear();
  Thread.Sleep(1000);
 }
 
}
