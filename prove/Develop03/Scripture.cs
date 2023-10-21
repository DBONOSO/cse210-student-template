using System;
using System.Collections;

class Scripture 
{
   private string text;
   private List<Word> words;

   public References Reference {get; private set;}

   public Scripture(string reference, string text)
   {
      Reference = new References();
      this.text = text;
      words = new List<Word>();

   InitializeWords();
   }
   private void InitializeWords()
   {  
      string[] wordArray = text.Split(' ');
      foreach (string word in wordArray);
      {
         words.Add(new Word(word));
      }
   }
   public bool AllWordsHidden()
   {
      return words.TrueForAll( word => word.IsHidden);
   }
   public void HideRandomWord()
   {
      int index = GetRandomHiddenWordIndex();
      if (index != -1)
      {

      }
   }
}
