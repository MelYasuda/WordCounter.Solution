using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _inputString;

    public string GetString()
    {
      return _inputString;
    }
    public void SetString(string inputString)
    {
      _inputString = inputString;
    }
  }

}
