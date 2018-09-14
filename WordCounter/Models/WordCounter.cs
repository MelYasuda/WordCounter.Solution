using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _inputString;
    private string _inputWordList;
    private string _result;

    public RepeatCounter(string inputString, string inputWordList)
    {
      _inputString = inputString;
      _inputWordList = inputWordList;
    }

    public string GetString()
    {
      return _inputString;
    }
    public string GetWordList()
    {
      return _inputWordList;
    }

    public string GetResult()
    {
      return _result;
    }
    public void SetResult(string inputResult)
    {
      _result = inputResult;
    }

    public bool CheckString()
    {
      if (_inputString == "")
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool CheckWordList()
    {
      if (_inputWordList == "")
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public string[] SplitString()
    {
      string[] splitedString = _inputWordList.Split(' ');
      return splitedString;
    }

    public bool CheckArray()
    {
      string[] splitedString = SplitString();
      if(splitedString.Length < 2 )
      {
        return false;
      }
      else
      {
        return true;
      }
    }

    public string LowerCaseString()
    {
      string loweredString = _inputString.ToLower();

      return loweredString;
    }

    public string[] LowerCaseArray()
    {
      string[] splitedString = SplitString();

      for (int i = 0; i<splitedString.Length; i++)
      {
        splitedString[i] = splitedString[i].ToLower();
      }
      return splitedString;
    }

    public int CountWord()
    {
      string[] loweredArray = LowerCaseArray();
      string loweredString = LowerCaseString();

      int count = 0;
      for (int i = 0; i<loweredArray.Length; i++)
      if(loweredArray[i] == loweredString)
      {
        count += 1;
      }
      else
      {
        count += 0;
      }
      return count;
    }
  }

  // public class program
  // {
  //   public static void Main()
  //   {
  //     Console.WriteLine("Enter a word");
  //     string userInputString = Console.ReadLine();
  //     Console.WriteLine("Enter a list of more than 2 words separated by spaces");
  //     Console.WriteLine("I will count how many times the first word appears");
  //     string userInputWordList = Console.ReadLine();
  //     RepeatCounter inputString = new RepeatCounter(userInputString, userInputWordList);
  //     // string checkedString = inputString.CheckString();
  //
  //     if(inputString.CheckString() || inputString.CheckWordList())
  //     {
  //       Console.WriteLine("Enter non-empty value");
  //     }
  //     else
  //     {
  //       inputString.SplitString();
  //       if(!inputString.CheckArray())
  //       {
  //         Console.WriteLine ("Enter more than 2 words");
  //       }
  //       else
  //       inputString.LowerCaseArray();
  //       {
  //         Console.WriteLine(inputString.CountWord());
  //       }
  //     }
  //   }
  // }
}
