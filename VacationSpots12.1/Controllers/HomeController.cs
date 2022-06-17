using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VacationSpots12._1.Models;
using VacationSpots12._1.Filters;
using Microsoft.AspNetCore.Authorization;


namespace VacationSpots12._1.Controllers
{

    [SimpleActionFilter]
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous] //any user can access the home index 
        public IActionResult Index()
        {
            //try
            //{
            //    int i, j;
            //    i = 5;
            //    j = 0;
            //    int k = i / j;

            //    throw new CustomException;
            //}


            //catch (CustomException ex)
            //{

            //    return RedirectToAction("Error");

            //}

            return View();

        }

        public IActionResult Privacy()
        {

            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();  //calls the error.cshtml from Home folder 
        }
    }
}
