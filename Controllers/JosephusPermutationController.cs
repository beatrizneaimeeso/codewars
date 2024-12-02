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
            var items = new List<object> { 1, 2, 3, 4, 5, 6, 7 };
            var k = 3;
            var result = JosephusPermutation.GetJosephusPermutation(items, k);
            return Ok(result);
        }
    }
}
