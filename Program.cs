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
     string userInput = Console.ReadLine();
     Word newWord = new Word();
     Console.WriteLine(newWord.ScoreCount(userInput));


    }
  }
}
