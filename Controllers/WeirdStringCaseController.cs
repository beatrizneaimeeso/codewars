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
    public class WeirdStringCaseController : Controller
    {
        [Route("weirdstringcase")]
        public IActionResult Index()
        {
            var weirdStringCase = new WeirdStringCase();            
            return Ok(weirdStringCase.ToWeirdCase("Beatriz Neaime"));
        }    
    }
}