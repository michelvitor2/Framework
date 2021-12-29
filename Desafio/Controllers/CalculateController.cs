using Desafio.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Desafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculateController : Controller
    {
        private readonly ICalculate _calculate;
        public CalculateController(ICalculate calculate)
        {
            _calculate = calculate;
        }
        [HttpGet("GetCalculateAllDivisorsNumber")]
        public IEnumerable<int> GetCalculateAllDivisorsNumber(int number)
        {
            return _calculate.CalculateAllDivisorsNumber(number).ToArray();
        }
        [HttpGet("GetCalculateAllPrimeDivisorsNumber")]
        public IEnumerable<int> GetCalculateAllPrimeDivisorsNumber(int number)
        {
            return _calculate.CalculateAllPrimeDivisorsNumber(number).ToArray();
        }
    }
}
