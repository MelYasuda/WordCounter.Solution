using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter;
using System;

[TestClass]
public class WordCounterTest
{
  // test getter and setter
  // [TestMethod]
  // public void GetString_ReturnsAString_String ()
  // {
  //   string word = "google";
  //   RepeatCounter inputString = new RepeatCounter(word);
  //   string result = inputString.GetString();
  //   Assert.AreEqual(word, result);
  // }
  // [TestMethod]
  // public void CheckString_EmptyString_String ()
  // {
  //   string word = "";
  //   RepeatCounter inputString = new RepeatCounter(word);
  //   bool result = inputString.CheckString();
  //   Assert.AreEqual(result, true);
  // }
  // [TestMethod]
  // public void SplitString_SplitBySpaces_List ()
  // {
  //   string[] wordsInArray = {"google", "apple"};
  //   string word = "google apple";
  //   RepeatCounter inputString = new RepeatCounter(word);
  //   // string gotString = inputString.GetString();
  //   string[] result = inputString.SplitString();
  //   CollectionAssert.AreEqual(result, wordsInArray);
  // }
  // [TestMethod]
  // public void CheckArray_MoreThanTwoElements_String ()
  // {
  //   string word = "google";
  //   RepeatCounter inputString = new RepeatCounter(word);
  //   // string gotString = inputString.GetString();
  //   bool result = inputString.CheckArray();
  //   Assert.AreEqual(result, false);
  // }
  // public void LowerCase_ChangeUpperToLowerCase_Array ()
  [TestMethod]
  {
    string[] loweredArray = {"google", "apple"};
    string word = "Google Apple";
    RepeatCounter inputString = new RepeatCounter(word);
    // string gotString = inputString.GetString();
    string[] result = inputString.LowerCase();
    CollectionAssert.AreEqual(result, loweredArray);
  }
  // [TestMethod]
  // public void CountWord_CompareToTheFirstElement_Int ()
  // {
  //   string word = "google google";
  //   RepeatCounter inputString = new RepeatCounter(word);
  //   // string gotString = inputString.GetString();
  //   int result = inputString.CountWord();
  //   Assert.AreEqual(result, 1);
  // }

}
