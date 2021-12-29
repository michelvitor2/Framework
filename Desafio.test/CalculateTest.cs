using Desafio.Domain;
using NUnit.Framework;

namespace Desafio.test
{
    public class CalculateTest
    {
        private readonly ICalculate _calculate;

        [SetUp]
        public void SetUp()
        {
          
            
        }
        public CalculateTest(ICalculate calculate)
        {
            _calculate = calculate;
        }
        
        [Test]
        public void CalculateAllDivisorsNumber_OneNumber_ReturnListInt()
        {
            var list = _calculate.CalculateAllDivisorsNumber(45);
            Assert.Equals(list.Count, 6);

        }
    }
}
