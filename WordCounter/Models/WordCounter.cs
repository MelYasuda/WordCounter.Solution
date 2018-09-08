using System.Collections.Generic;
using System;

namespace WordCounter
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
    public bool CheckString()
    {
      if (_inputString == "")
      {
        return false;
      }
      else
      {
        return true;
      }
    }

    public string[] SplitString()
    {
      string[] splitedString = _inputString.Split(' ');
      return splitedString;
    }

    public bool CheckArray()
    {
      string[] splitedString = _inputString.Split(' ');
      if(splitedString.Length < 2 )
      {
        return false;
      }
      else
      {
        return true;
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

  public class program
  {
    public static void Main()
    {
      Console.WriteLine("Enter words separated by spaces");
      Console.WriteLine("I will count how many times the first word appears");
      string userInput = Console.ReadLine();
      RepeatCounter inputString = new RepeatCounter(userInput);
      // string checkedString = inputString.CheckString();

      if(!inputString.CheckString())
      {
        Console.WriteLine("Enter non-empty value");
      }
      else
      {
        inputString.SplitString();
        if(!inputString.CheckArray())
        {
          Console.WriteLine ("Enter more than 2 words");
        }
        else
        {
          inputString.LowerCase();
          Console.WriteLine(inputString.CountWord());
        }
      }

    }
  }
}
