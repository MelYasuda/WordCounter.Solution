using System.Collections.Generic;
using System;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string _inputString;
    private static List<RepeatCounter> _instances = new List<RepeatCounter> {};

    public RepeatCounter(string inputString)
    {
      _inputString = inputString;
    }

    public string GetString()
    {
      return _inputString;
    }
    // public void SetString(string inputString)
    // {
    //   _inputString = inputString;
    // }
    public string CheckString ()
    {
      if (_inputString == "")
      {
        return "Enter non-empty value";
      }
      else
      {
        return _inputString;
      }
    }

    public string[] SplitString()
    {
      string[] splitedString = _inputString.Split(' ');
      return splitedString;
    }

    public string CheckArray()
    {
      string[] splitedString = _inputString.Split(' ');
      if(splitedString.Length < 2 )
      {
        return "you loser";
      }
      else
      {
        return _inputString;
      }
    }

    public string[] LowerCase()
    {
      string[] splitedString = _inputString.Split(' ');

      for (int i = 0; i<splitedString.Length; i++)
      {
        splitedString[i] = splitedString[i].ToLower();
      }
      // foreach (string word in splitedString)
      // {
      //    splitedString = word.ToLower();
      // }
      return splitedString;
    }

    public int CountWord()
    {
      string[] splitedString = _inputString.Split(' ');

      int count = 0;
      for (int i = 1; i<splitedString.Length; i++)
      if(splitedString[i] == splitedString[0])
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
}
