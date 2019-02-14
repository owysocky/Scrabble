using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordTest
  {
    [TestMethod]
     public void IsLetter_EnterOneLetter_True()
     {
       Word testLetter = new Word();
       Assert.AreEqual(true, testLetter.IsLetter("r"));
     }

     [TestMethod]
     public void IsLetter_NotANumber_True()
     {
       Word testLetter = new Word();
       Assert.AreEqual(false, testLetter.IsLetter("1"));
     }

     [TestMethod]
     public void ScoreCount_CountScore_True()
     {
       Word testLetter = new Word();
       Assert.AreEqual(8, testLetter.ScoreCount("j"));
     }

     [TestMethod]
     public void ScoreCount_CountScoreSecond_True()
     {
       Word testLetter = new Word();
       Assert.AreEqual(13, testLetter.ScoreCountSecond("j", "k"));
     }

  }
}
