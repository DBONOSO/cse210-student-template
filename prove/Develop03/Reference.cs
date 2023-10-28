  using System;
  using System.Collections;

  class ScriptureReference
  {
   private string _book = "1 nephi";
   private string _chapter = "4";
   private string _startVerse = "6";

   private string _endVerse;

   public ScriptureReference(string _startVerse)
   {

   }
   public ScriptureReference(string _startVerse, string _endVerse)
   {
    
   }

   public string createReference()
   {
    if (_startVerse != null && _endVerse != null)
    {
       string reference = $"{_book} {_chapter}: {_startVerse}-{_endVerse}";
       return reference;
    } else
    {
       string reference = $"{_book} {_chapter}:{_startVerse}";
       return reference;
    }
   }
  }
