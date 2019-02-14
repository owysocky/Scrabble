using System;
using System.Collections.Generic;
using System.Linq;

namespace theGame
{
  public class Word {
    string one = "AEIOULNRST";
    string two = "DG";
    string three = "BCMP";
    string four = "FHVWY";
    string five = "K";
    string eight = "JX";
    string ten = "QZ";

    public int ScoreCount(string word)
    {
      string wordUpper = word.ToUpper();

      int score = 0;

      foreach (char c in wordUpper) {
        string cString = c.ToString();
        if(one.Contains(cString))
        {
          score+=1;
        }
        else if(two.Contains(cString))
        {
          score+=2;
        }
        else if(three.Contains(cString))
        {
          score+=3;
        }
        else if(four.Contains(cString))
        {
          score+=4;
        }
        else if(five.Contains(cString))
        {
          score+=5;
        }
        else if(eight.Contains(cString))
        {
          score+=8;
        }
        else if(ten.Contains(cString))
        {
          score+=10;
        }
        else
        {
          return score;
        }
      }

      return score;
    }
  }
}
