using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MovieMVC.Controllers
{
    public  class HelloWorldController : Controller
    {
        //Get : /HelloWorld/
        public string Index()
        {
            return "this is my default Action";
        }

        //GET: /HelloWorld/Welcome

        public string Welcome()
        {
            return "this is welcome tag";
        }
    }
}