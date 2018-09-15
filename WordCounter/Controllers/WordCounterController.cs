using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class GamesController : Controller
  {
    [HttpGet("/games")]
    public ActionResult InputForm()
    {
      List<RepeatCounter> allGames = RepeatCounter.GetAll();
      return View(allGames);
    }

    [HttpPost("/games")]
    public ActionResult Play()
    {
        RepeatCounter inputString = new RepeatCounter(Request.Form["word"], Request.Form["word-list"]);
        if(inputString.CheckString() || inputString.CheckWordList())
        {
          string messege = "Enter non-empty value";
          inputString.SetResult(messege);
          return View("Result", inputString);
        }
        else
        {
          inputString.SplitString();
          if(!inputString.CheckArray())
          {
            inputString.SetResult("Enter more than 2 words");
            return View("Result", inputString);
          }
          else
          inputString.EliminateDotComma();
          {
            int count = inputString.CountWord();
            string result = "Your word is repeated " + count.ToString() + " time(s) in the word list.";
            inputString.SetResult(result);
            return View("Result", inputString);

            // Console.WriteLine(inputString.CountWord());
          }
        }
    }
  }
}
