using FishWebConnection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FishWebConnection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // TRY-CATCH
            try
            {
                return View();
            }
            catch (Exception)
            {
                return RedirectToAction("EnFulErrorSida");
            }

            
        }

        public IActionResult Privacy()
        {
            // TRY-CATCH
            try
            {
                return View();
            }
            catch (Exception)
            {
                return RedirectToAction("EnFulErrorSida");
            }

         
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // TRY-CATCH
            try
            {
              return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
            catch (Exception)
            {
                return RedirectToAction("EnFulErrorSida");
            }

         
        }
    }
}
