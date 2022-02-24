using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System;
using System.Collections.Generic;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScoreTests
  {

    [TestMethod]
    public void ScoreConstructor_CreateInstanceOfScore_Score()
    {
      Score testScore = new Score("test");
      Assert.AreEqual(typeof(Score), testScore.GetType());
    }

    [TestMethod]
    public void GetEntry_ReturnEntry_String()
    {
      string entry = "Abcedarian";
      Score testScore = new Score(entry);
      
      string result = testScore.Entry;
      Assert.AreEqual(entry, result);
    }
  }
}