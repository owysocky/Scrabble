using System;

namespace Scrabble
{
  public class Word
  {
    public bool IsLetter(string letter)
    {
      double myNum = 0;
      if (String.IsNullOrEmpty(letter))
      {
        return false;
      }
      else if(Double.TryParse(letter, out myNum))
      {
        return false;
      }
      else
      {
        return true;
      }
    }

    public int ScoreCount(string letter)
    {
      if(letter == "j")
      {
        return 8;
      }
      else
      {
        return 0;
      }
    }

    public int ScoreCountSecond(string letter, string letter2)
    {
      int counter = 0;
      string[] myArray = new string[] {letter, letter2};
      foreach (string element in myArray) {
        if(element == "j")
        {
          counter=+8;
        }else if(element == "k")
        {
          counter+=5;
        }
      }
      return counter;
    }

  }
}
