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
    string word = "google";
    RepeatCounter inputString = new RepeatCounter(word);
    string result = inputString.GetString();
    Assert.AreEqual(word, result);
  }
  [TestMethod]
  public void CheckString_EmptyString_String ()
  {
    string word = "";
    RepeatCounter inputString = new RepeatCounter(word);
    string result = inputString.CheckString();
    Assert.AreEqual("Enter non-empty value", result);
  }

}
