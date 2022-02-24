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
    public void CalculateScore_ReturnNullScore_Int()
    {
      Score testScore = new Score("test");
      int result = testScore.CalculateScore();
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void CalculateScore_ReturnScore_Int()
    {
      string entry = "Xi";
      Score testScore = new Score(entry);
      int wordScore = testScore.CalculateScore();
      Assert.AreEqual(9, wordScore);
    }
  }
}