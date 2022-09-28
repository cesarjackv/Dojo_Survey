using Microsoft.AspNetCore.Mvc;
namespace Dojo_Survey.Controllers;     //be sure to use your own project's namespace!
    public class Dojo_SurveyController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Results")]
        public IActionResult Results(string name, string Location, string Language, string msg)
        {
            ViewBag.name = name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.msg = msg;
            return View();
        }
}

