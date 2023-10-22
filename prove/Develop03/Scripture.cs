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
      foreach (string word in wordArray)
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
         words[index].IsHidden = true;
      }
   }

   public void Display()
   {
      Console.Clear();
      Console.Write($"{Reference}: ");
      foreach (Word word in words)
      {
         Console.Write(word.IsHidden ? "******" : word.Text + " ");
      }
      Console.WriteLine();
   }

   private int GetRandomHiddenWordIndex()
   {
      List<int> hiddenWordIndices = new List<int>();

      for (int i = 0; i < words.Count; i++)
      {
         if (!words[i].IsHidden)
         {
            hiddenWordIndices.Add(i);
         }
      }

      if (hiddenWordIndices.Count > 0)
      {
         Random random = new Random();
         int randomIndex = random.Next(hiddenWordIndices.Count);
         return hiddenWordIndices[randomIndex];
      }
      return -1;
   }
   
}
