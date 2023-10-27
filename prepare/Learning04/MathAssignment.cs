using System;

namespace Library_demo
{
 public class MathAssignments : Assignment
 {
  private string _maths = "";

  public string GetHomeworkList()
  {
   return _maths;
  }

  public void SetMaths(string maths)
  {
   _maths = maths;
  }
 } 

}