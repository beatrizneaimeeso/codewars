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
    public class JosephusPermutationController : Controller
    {
        private readonly ILogger<JosephusPermutationController> _logger;

        public JosephusPermutationController(ILogger<JosephusPermutationController> logger)
        {
            _logger = logger;
        }

        [Route("josephus-permutation")]
        public IActionResult Index()
        {
            var items = new List<object> { "C", "o", "d", "e", "W", "a", "r", "s" };
            var k = 4;
            var result = JosephusPermutation.GetJosephusPermutation(items, k);
            return Ok(result);
        }
    }
}
