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
    [TestMethod]
    public void SetEntry_ChangeEntry_String()
    {
      string entry = "Abcedarian";
      Score testScore = new Score(entry);
      string updatedEntry = "Xi";
      testScore.Entry = updatedEntry;
      string result = testScore.Entry;
      Assert.AreEqual(updatedEntry, result);

    }

    [TestMethod]
    public void calculateScore_returnScore_String()
    {
      Score testScore = new Score("test");
      int result = testScore.calculateScore();
      Assert.AreEqual(0, result);
    }
  }
}