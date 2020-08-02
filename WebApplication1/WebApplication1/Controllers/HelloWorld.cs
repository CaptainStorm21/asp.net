using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MovieMVC.Controllers
{
    public  class HelloWorldController : Controller
    {
        //Get : /HelloWorld/

        // Test 1
        //public string Index()
        //{
        //    return "this is my default Action";
        //}

        public IActionResult Index()
        {
            return View();
        }

        //GET: /HelloWorld/Welcome

        public string Welcome()
        {
            return "this is welcome tag";
        }
    }
}