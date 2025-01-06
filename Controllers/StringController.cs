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

        [HttpGet]
        [Route("~/spinningwords")]
        public IActionResult SpinWords()
        {
            var sentence = "You are almost to the last test";
            var result = SpinningWords.SpinWords(sentence);
            return Ok(result);
        }

        [HttpGet]
        [Route("~/validbraces")]
        public IActionResult FindValidBraces()
        {
            var braces = "({[]})";
            var result = ValidBraces.FindValidBraces(braces);
            return Ok(result);
        }

        [HttpGet]
        [Route("~/suzuki-students")]
        public IActionResult SuzukiStudentsProblem()
        {
            var students = "Tadashi Takahiro Takao Takashi Takayuki Takehiko Takeo Takeshi Takeshi";
            var result = SuzukiStudents.LineupStudents(students);
            return Ok(result);
        }

        [HttpGet]
        [Route("~/text-align")]
        public IActionResult TextAlignJustify()
        {
            var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor mauris, at elementum ligula tempor eget. In quis rhoncus nunc, at aliquet orci. Fusce at dolor sit amet felis suscipit tristique. Nam auctor mauris non justo consequat, in ornare lacus posuere. Sed nec nulla aliquam, bibendum odio eget, laoreet metus. Nulla nec erat nec lectus elementum luctus. Nam venenatis erat a lectus ultrices, eget rutrum justo viverra. Cr";

            var result = TextAlign.Justify(text, 30);
            return Ok(result);
        }
    }
}
