using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CodeWars.Interfaces;
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

        [Route("~/duplicate-count")]
        public IActionResult DuplicateCounts()
        {
            var count = DuplicateCount.CountDuplicates("ABBA");
            return Ok(count);
        }

        [Route("~/tictactoe")]
        public IActionResult TicTacToeClass()
        {
            var board = new int[,]
            {
                { 1, 2, 1 },
                { 1, 1, 2 },
                { 2, 2, 0 },
            };
            var result = TicTacToe.TicTacToeChecker(board);
            return Ok(result);
        }

        [Route("~/pop-growth")]
        public IActionResult PopulationGrowth()
        {
            var years = PopGrowth.NbYear(1500, 5, 100, 5000);
            return Ok(years);
        }

        [Route("~/pong")]
        public IActionResult PongGame()
        {
            var pong = new Pong(2);
            var results = new List<string>
            {
                pong.play(50, 53),
                pong.play(100, 97),
                pong.play(0, 4),
                pong.play(25, 25),
                pong.play(75, 25),
                pong.play(50, 50),
            };
            return Ok(results);
        }

        [Route("~/delete-occurrences")]
        public IActionResult DeleteOccurrences()
        {
            var result = DeleteOccurrencesClass.DeleteNth(
                new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 },
                3
            );
            return Ok(result);
        }

        [Route("~/supermarket-queue")]
        public IActionResult Supermarket()
        {
            var result = SupermarketQueue.QueueTime(new int[] { 2, 2, 3, 3, 4, 4 }, 2);
            return Ok(result);
        }

        [Route("~/rock-paper-scissors")]
        public IActionResult RockPaperScissorsGame()
        {
            var playground = new RockPaperScissorsPlayground();
            var player = new Player();
            var result = playground.PlayTournament(player);

            foreach (var l in playground.GetMatchResults())
            {
                Console.WriteLine(l);
            }

            if (!result)
            {
                Console.WriteLine(
                    $"You are eliminated from the tournament by {playground.GetLastOpponent()}!"
                );
            }

            return Ok(result);
        }

        [Route("~/ten-minutes-walk")]
        public IActionResult TakeAWalk()
        {
            var walk = new string[] { "n", "s", "n", "s", "n", "s", "n", "s" };
            var result = TenMinutesWalk.IsValidWalk(walk);
            return Ok(result);
        }

        [Route("~/human-readable-time")]
        public IActionResult HumanReadableTime()
        {
            var result = HumanTime.GetReadableTime(1600);
            return Ok(result);
        }
    }
}
