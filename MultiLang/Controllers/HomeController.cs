using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using MultiLang.Models;

namespace MultiLang.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult Hr()
        {
            return View();
        }
        public IActionResult Crm()
        {
            return View();
        }
        public IActionResult Inventory()
        {
            return View();
        }
    }
}
