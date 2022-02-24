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
      Score testScore = new Score();
      Assert.AreEqual(typeof(Score), testScore.GetType());
    }
  }







}