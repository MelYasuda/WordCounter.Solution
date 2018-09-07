using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _inputString;

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
        return "good day";
      }
    }
  }

}
