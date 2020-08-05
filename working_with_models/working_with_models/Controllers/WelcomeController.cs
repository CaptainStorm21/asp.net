using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop;
using working_with_models.Models;

namespace working_with_models.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            //Mockdata
            MockData myData = new MockData();
            string name = myData.GetName();
            int numTimes = myData.GetnumTimes();

            ViewData  ["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
