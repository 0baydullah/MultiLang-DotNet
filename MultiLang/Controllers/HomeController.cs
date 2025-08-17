using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MultiLang.Models;

namespace MultiLang.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
