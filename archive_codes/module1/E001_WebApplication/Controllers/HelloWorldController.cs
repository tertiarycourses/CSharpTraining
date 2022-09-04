using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E001_WebApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public String Index()
        {
            return "Hello World: Angel says Welcome!";
        }
    }
}
