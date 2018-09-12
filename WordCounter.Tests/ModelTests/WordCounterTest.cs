using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter;
using System;

[TestClass]
public class WordCounterTest
{
  // test getter and setter
  [TestMethod]
  public void GetString_ReturnsAString_String ()
  {
    string word = "google";
    string list = "google apple";
    RepeatCounter inputString = new RepeatCounter(word, list);
    string result = inputString.GetString();
    Assert.AreEqual(word, result);
  }
  [TestMethod]
  public void GetString_ReturnsAString2_String ()
  {
    string word = "google";
    string list = "google apple";
    RepeatCounter inputString = new RepeatCounter(word, list);
    string result = inputString.GetWordList();
    Assert.AreEqual(list, result);
  }


  // check empty string
  [TestMethod]
  public void CheckString_EmptyString_String ()
  {
    string word = "";
    string list = "";
    RepeatCounter inputString = new RepeatCounter(word, list);
    bool result = inputString.CheckString();
    Assert.AreEqual(result, true);
  }
  [TestMethod]
  public void CheckString_EmptyWordList_String ()
  {
    string word = "";
    string list = "";
    RepeatCounter inputString = new RepeatCounter(word, list);
    bool result = inputString.CheckWordList();
    Assert.AreEqual(result, true);
  }

  // split the word list into array
  [TestMethod]
  public void SplitWordList_SplitBySpaces_List ()
  {
    string[] wordsInArray = {"google", "apple"};
    string word = "google";
    string wordList = "google apple";
    RepeatCounter inputString = new RepeatCounter(word, wordList);
    // string gotString = inputString.GetString();
    string[] result = inputString.SplitString();
    CollectionAssert.AreEqual(result, wordsInArray);
  }

  // check if the array has more than 2 word
  [TestMethod]
  public void CheckArray_MoreThanTwoElements_String ()
  {
    string word = "google";
    string list = "google";
    RepeatCounter inputString = new RepeatCounter(word, list);
    // string gotString = inputString.GetString();
    bool result = inputString.CheckArray();
    Assert.AreEqual(result, false);
  }

  // uppercase the string and the array
  [TestMethod]
  public void LowerCase_ChangeUpperToLowerCase_Array ()
  {
    string[] loweredArray = {"google", "apple"};
    string list = "Google Apple";
    string word = "Google";
    RepeatCounter inputString = new RepeatCounter(word, list);
    // string gotString = inputString.GetString();
    string[] result = inputString.LowerCaseArray();
    CollectionAssert.AreEqual(result, loweredArray);
  }

  [TestMethod]
  public void LowerCase_ChangeUpperToLowerCase_String ()
  {
    string list = "Google Apple";
    string word = "Google";
    string loweredWord = "google";
    RepeatCounter inputString = new RepeatCounter(word, list);
    // string gotString = inputString.GetString();
    string result = inputString.LowerCaseString();
    Assert.AreEqual(result, loweredWord);
  }

  // check the word in the array
  [TestMethod]
  public void CountWord_CompareToTheFirstElement_Int ()
  {
    string word = "google";
    string list = "google google";
    RepeatCounter inputString = new RepeatCounter(word, list);
    // string gotString = inputString.GetString();
    int result = inputString.CountWord();
    Assert.AreEqual(result, 2);
  }
}
