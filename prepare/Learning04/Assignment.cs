using System;

namespace Library_demo
{
  public class Assignment
  {
      private string _name = "";
      private string _topic = "";
      
      public string GetName()
      {
       return _name;
      }
      public void SetName(string name)
      {
         _name = name;
      }
      public string GetTopic()
      {
         return _topic;
      }
      public void SetTopic(string topic)
      {
       _topic = topic;
      }
  public string GetSummary()
      {
       return $"{_name} - {_topic}";
      }

 }
}