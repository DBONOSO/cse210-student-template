
using System;
using System.Collections.Generic;
class Word
{
   private bool isHidden = false;

   public Word()
   {

   }

   public string separateWords(string scriptureString)
   {
      string str1 = scriptureString;
      List<string> result = str1?.Split(' ').ToList();
      var random = new Random();
      int index = random.Next(result.Count);
      string randomWord = result[index];
      Console.WriteLine(randomWord);
      return randomWord;
   }
}  