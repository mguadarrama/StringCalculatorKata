using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StringCalculatorKata;

namespace StringCalculatorKataWeb.Controllers
{
    public class HomeController : Controller
    {
        StringCalculator stringCalculator = new StringCalculator();

        //private IStringCalculator calculator;
        //public HomeController(IStringCalculator stringCalculator)
        //{
        //    calculator = stringCalculator;
        //}
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

    public class HomeViewModel
    {
        public string  valueString { get; set; }
        public int returnValue { get; set; }
    }
}