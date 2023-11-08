   using System;


   class ListingActivity : Activity
   {
    private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private string _startMessage = "Welcome to the listing activity";
    private string _endMessage = "";
    private string _considerPrompMessage = "Consider the following prompt";
    private List<string> _promptList = new List<string>{"Who are people that you appreciate?",
   "What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};

   protected string _name = "Listing Activity";
   private int _numberOfListItems;

   public ListingActivity(int duration) : base(duration)
   {
    _numberOfListItems = 0;
    _duration = duration;
   }

   public void runListingActivity(int duration)
   {
    Console.WriteLine(_startMessage);
    Console.WriteLine(_description);
    Activity activity = new Activity();
    activity.setDuration();
    _duration = activity.getDuration();
    listing();
    Console.WriteLine(_wellDone);
    _endMessage = $"You fnished {_duration / 100} seconds of listing";
    Console.WriteLine(_endMessage);
    Thread.Sleep(6000);
    Console.Clear();
   }
   public void listing()
   {
    Thread.Sleep(1000);
    Console.Clear();
    Console.WriteLine(_considerPrompMessage);
    var random = new Random();
    int index = random.Next(_promptList.Count);
    string randomPrompt = _promptList[index];
    Console.WriteLine(randomPrompt);
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(5);
    DateTime currentTime = DateTime.Now;
    if (currentTime < endTime)
    {
     Console.Write("Seconds until start:  ");
     for (int i = 5; i > 0; i--)
     {
      Console.Write("\b \b");
      Console.Write(i);
      Thread.Sleep(1000);
     }
     Console.Write("\b \b");
    }
    Console.Write(">");
    DateTime startTime1 = DateTime.Now;
    DateTime endTime1 = startTime1.AddSeconds(_duration / 100);
    while (DateTime.Now < endTime1)
    {
     string userInput = Console.ReadLine();
     _numberOfListItems ++;
     Console.Write("\b \b");
     Console.WriteLine(">");
    }
    Thread.Sleep(1000);
    displayNumberOfListItems();
   }

   public void displayNumberOfListItems()
   {
    Console.WriteLine($"You listed {_numberOfListItems} items.");
   }
   }