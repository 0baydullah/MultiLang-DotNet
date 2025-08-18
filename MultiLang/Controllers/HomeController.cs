using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using MultiLang.Models;

namespace MultiLang.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<SharedResource> _localizer;

        public HomeController(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            //ViewData["Hello"] = _localizer["Hello"];
           // ViewData["Message"] = _localizer["This is a localized message."];
            return View();
        }

        public IActionResult Privacy()
        {
         //   ViewData["PrivacyMessage"] = _localizer["This is a localized privacy message."];
           // ViewData["Privacy"] = _localizer["Privacy Default."];
            return View();
        }
    }
}
