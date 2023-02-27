using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Landing() { return View(); }

    [Route("/MadlibMonster")]
    public ActionResult MadlibMonster(string noun, string verb, string adj, string color, string monster, string name) 
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Noun = noun;
      myLetterVariable.Verb = verb;
      myLetterVariable.Adj = adj;
      myLetterVariable.Color = color;
      myLetterVariable.Monster = monster;
      myLetterVariable.Name = name;
      return View(myLetterVariable);
    }
  }
}