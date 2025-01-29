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
            var text = "123 45 6";

            var result = TextAlign.Justify(text, 7);
            return Ok(result);
        }

        [HttpGet]
        [Route("~/path-finder")]
        public IActionResult PathFinder()
        {
            var maze = "......\n" + "......\n" + "......\n" + "......\n" + ".....W\n" + "....W.";
            var result = Finder.PathFinder(maze);
            return Ok(result);
        }

        [HttpGet]
        [Route("~/climbers-rankings")]
        public IActionResult ClimbersRanking()
        {
            var pointsByClimber = new Dictionary<string, IEnumerable<int>>
            {
                { "SKOFIC Domen", new[] { 55, 100, 100, 25, 100, 51, 80 } },
            };
            var result = ClimbersRankings.GetRankings(pointsByClimber);
            return Ok(result);
        }

        [HttpGet]
        [Route("~/breadcrumb")]
        public IActionResult Breadcrumb()
        {
            string[] urls = new string[]
            {
                "mysite.com/pictures/holidays.html",
                "www.codewars.com/users/GiacomoSorbi?ref=CodeWars",
                "www.microsoft.com/docs/index.htm#top",
                "mysite.com/very-long-url-to-make-a-silly-yet-meaningful-example/example.asp",
                "www.very-long-site_name-to-make-a-silly-yet-meaningful-example.com/users/giacomo-sorbi",
                "https://www.linkedin.com/in/giacomosorbi",
                "www.agcpartners.co.uk/",
                "www.agcpartners.co.uk",
                "https://www.agcpartners.co.uk/index.html",
                "http://www.agcpartners.co.uk",
            };
            string[] seps = new string[]
            {
                " : ",
                " / ",
                " * ",
                " > ",
                " + ",
                " * ",
                " * ",
                " # ",
                " >>> ",
                " % ",
            };
            List<string> result = new List<string>();

            foreach (var item in urls)
            {
                result.Add(BreadcrumbGenerator.GenerateBC(item, seps[urls.ToList().IndexOf(item)]));
            }

            return Ok(result);
        }

        [HttpGet]
        [Route("~/scramble-generator")]
        public IActionResult ScrambleGenerator()
        {
            var words = new string[]
            {
                "rkqodlw",
                "cedewaraaossoqqyt",
                "katas",
                "scriptjavx",
                "scriptingjava",
                "scriptsjava",
                "javscripts",
                "aabbcamaomsccdd",
                "commas",
                "sammoc",
            };

            var compare = new string[]
            {
                "world",
                "codewars",
                "steak",
                "javascript",
                "javascript",
                "javascript",
                "javascript",
                "commas",
                "commas",
                "commas",
            };

            var result = new List<bool>();

            for (int i = 0; i < words.Length; i++)
            {
                result.Add(Scramble.ScrambleCheck(words[i], compare[i]));
            }

            return Ok(result);
        }

        [HttpGet]
        [Route("~/custom-xmas-tree")]
        public IActionResult CustomXmasTree()
        {
            var result = ChristmasTree.CustomChristmasTree("1234", 6);
            return Ok(result);
        }
    }
}
