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

        [Route("~/stock-list")]
        public IActionResult StockList()
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

        [Route("~/accumul")]
        public IActionResult Accumul()
        {
            var classInstance = new Accumul("RqaEzty");
            var result = classInstance.Accum();
            return Ok(result);
        }

        [Route("~/plugboard/start")]
        public IActionResult Plugboard()
        {
            var plugboard = new Plugboard("ABCDEFGHIJKLMNOPQRST");
            var result = plugboard.Process('.');
            return Ok(result);
        }

        [Route("~/josephus-permutation")]
        public IActionResult Josephus()
        {
            var items = new List<object> { "C", "o", "d", "e", "W", "a", "r", "s" };
            var k = 4;
            var result = JosephusPermutation.GetJosephusPermutation(items, k);
            return Ok(result);
        }

        [Route("~/weirdstringcase")]
        public IActionResult WeirdString()
        {
            var weirdStringCase = new WeirdStringCase();
            return Ok(weirdStringCase.ToWeirdCase("Beatriz Neaime"));
        }

        [HttpGet]
        [Route("cryptography/encryptthis")]
        public IActionResult Index([FromBody] EncryptThisRequest input)
        {
            var encrypt = Cryptography.EncryptThis(input.Input);
            var decrypt = Cryptography.DecryptThis(encrypt);
            return Ok(new { encrypt, decrypt });
        }
    }
}
