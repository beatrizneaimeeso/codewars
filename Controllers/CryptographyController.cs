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
    public class CryptographyController : Controller
    {
        private readonly ILogger<CryptographyController> _logger;

        public CryptographyController(ILogger<CryptographyController> logger)
        {
            _logger = logger;
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

    public class EncryptThisRequest
    {
        public string Input { get; set; }
    }
}
