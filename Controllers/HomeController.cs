using calucater.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace calucater.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Privacy(post post)
        {
            post.res=0;
            switch(post.state)
            {
                case '+':
                    post.res = post.num1 + post.num2;
                    break;  
                case '-':
                    post.res = post.num1 - post.num2;
                    break;
                case '*':
                    post.res = post.num1 * post.num2;
                    break ;
                case '/':
                    post.res = post.num1 / post.num2;
                    break;
            }
            ViewBag.res2=post.res;
            return View();
        }
    }
}