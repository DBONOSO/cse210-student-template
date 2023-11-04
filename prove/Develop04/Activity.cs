    using System;
    class Activity
    {
    protected int _duration;
    protected string _wellDone = "Well done!";
    public Activity()
    {
      _duration = 20;
    }
    public Activity(int duration)
    {
      _duration = duration;
    }
    public void runActivity(int choice)
    {
      if (choice == 1)
      {
      BreathingActivity breathingActivity = new BreathingActivity(_duration);
      breathingActivity.runBreathingActivity(_duration);
      }
      else if (choice == 2)
      {
      ReflectingActivity reflectingActivity = new ReflectingActivity(_duration);
      reflectingActivity.runReflectingActivity(_duration);
      }
      else if (choice == 3)
      {
      ListingActivity listingActivity = new ListingActivity(_duration);
      listingActivity.runListingActivity(_duration);
      }
    }
    public void setDuration()
    {
      Console.WriteLine("How long, in seconds, would you like for your session? ");
      string response = Console.ReadLine();
      int duration = int.Parse(response);
      _duration = duration * 100;
    }
    public int getDuration()
    {
      return _duration;
    }


    }