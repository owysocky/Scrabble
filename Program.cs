using System;
using System.Collections.Generic;
using System.Linq;

namespace theGame{
  public class Program
  {
    public static void Main()
    {

     Console.WriteLine("====================================");
     Console.WriteLine("SCRABBLE SCORE");
     Console.WriteLine("Enter a word: ");
     Word newWord = new Word();
     string userInput = Console.ReadLine();
     double testNum = 0;
     if(Double.TryParse(userInput, out testNum))
     {
       Console.WriteLine("I am sorry, I can't evaluate a number!");
       Main();
     }
     else if (String.IsNullOrEmpty(userInput))
     {
       Console.WriteLine("I am sorry, you didn't eneter a word!");
       Main();
     }
     else{
       Console.WriteLine("The score for your word is: " +
       newWord.ScoreCount(userInput));
     }

    }
  }
}
