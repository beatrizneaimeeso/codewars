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
    public class PlugboardController : Controller
    {
        private readonly ILogger<PlugboardController> _logger;

        public PlugboardController(ILogger<PlugboardController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/plugboard/start")]
        public IActionResult Index()
        {
            var plugboard = new Plugboard("ABCDEFGHIJKLMNOPQRST");
            var result = plugboard.Process('.');
            return Ok(result);
        }

        [HttpGet]
        [Route("/plugboard/accumul")]
        public IActionResult Accumul()
        {
            var classInstance = new Accumul("RqaEzty");
            var result = classInstance.Accum();
            return Ok(result);
        }
    }
}
