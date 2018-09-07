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
  }

}
