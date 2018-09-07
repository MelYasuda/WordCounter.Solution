using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;

[TestClass]
public class WordCounterTest
{
  // test getter and setter
  [TestMethod]
  public void GetString_ReturnsAString_String ()
  {
    RepeatCounter inputString = new RepeatCounter();
    string word = "google";
    inputString.SetString(word);
    string result = inputString.GetString();
    Assert.AreEqual(word, result);
  }

}
