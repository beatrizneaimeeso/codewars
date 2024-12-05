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
    public class NumericController : Controller
    {
        private readonly ILogger<NumericController> _logger;

        public NumericController(ILogger<NumericController> logger)
        {
            _logger = logger;
        }

        [Route("~/max-product")]
        public IActionResult Index()
        {
            var max = MaximumProduct.AdjacentElementsProduct([9, 5, 10, 2, 24, -1, -48]);
            return Ok(max);
        }

        [Route("~/nth-smallest")]
        public IActionResult NthSmallest()
        {
            var nth = NthSmallestElement.NthSmallest([15, 20, 7, 10, 4, 3], 3);
            return Ok(nth);
        }

        [Route("~/handshake/{n}")]
        public IActionResult Handshake(int n)
        {
            var participants = HandshakeProblem.GetParticipants(n);
            return Ok(participants);
        }
    }
}
