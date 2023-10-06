using System;
using System.Collections.Generic;

public class Journal {

     public string _file;

     public List<Entry> _entries = new List<Entry>();

     public void DisplayJournal()
     {
      foreach (Entry entry in _entries)
      {
         entry.DisplayEntry();
      }
     }
     public void SaveToFile()
     {
      using (StreamWriter outputFile = new StreamWriter(_file))
      {
        foreach (Entry entry in _entries)
        {
         outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
        }
      }
     }
     public void LoadFile()
     {
      
        string[] lines = System.IO.File.ReadAllLines(_file);
        foreach(string line in lines)
        {
         string[] parts = line.Split(",");

         Entry selection = new Entry();
         selection._date = parts[0];
         selection._prompt = parts[1];
         selection._response = parts[2];
         _entries.Add(selection);

  }


 }
}