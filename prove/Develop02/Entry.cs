using System;

public class Entry
{
 public string _date;
 public string _prompt;
 public int _response;

 public void DisplayEntry()
 {
  Console.WriteLine($" Date: {_date} Prompt: ({_prompt}) Response: {_response}");
 }
}