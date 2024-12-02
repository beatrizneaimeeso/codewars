using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CodeWars.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CodeWars.Controllers
{
    public class StockListController : Controller
    {
        private readonly ILogger<StockListController> _logger;

        public StockListController(ILogger<StockListController> logger)
        {
            _logger = logger;
        }

        [Route("/stock-list")]
        public IActionResult Index()
        {
            var stocklist = new StockList();
            var lstOfArt = new string[]
            {
                "ABART 20",
                "CDXEF 50",
                "BKWRK 25",
                "BTSQZ 89",
                "DRTYM 60",
                "ABART 20",
            };
            var lstOf1stLetter = new string[] { "A", "B", "C", "W" };
            var result = stocklist.stockSummary(lstOfArt, lstOf1stLetter);
            return Ok(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
