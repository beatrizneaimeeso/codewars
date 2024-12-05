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
    [Route("[controller]")]
    public class StringController : Controller
    {
        private readonly ILogger<StringController> _logger;

        public StringController(ILogger<StringController> logger)
        {
            _logger = logger;
        }

        [Route("~/backspaces")]
        public IActionResult Index()
        {
            var cleaned = Backspaces.CleanString("abc####d##c#");
            return Ok(cleaned);
        }
    }
}
