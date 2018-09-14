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
      return View();
    }
  }
}
