using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StringCalculatorKata;
using StringCalculatorWeb.ViewModels;

namespace StringCalculatorWeb.Controllers
{
    public class HomeController : Controller
    {

        private IStringCalculator stringCalculator;
        public HomeController(IStringCalculator stringCalculator)
        {
            this.stringCalculator = stringCalculator;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HomeViewModel homeViewModel)
        {
            homeViewModel.returnValue =
                stringCalculator.Add(homeViewModel.valueString);
            return View(homeViewModel);
        }

    }
}