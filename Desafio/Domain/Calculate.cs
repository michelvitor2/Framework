using System.Collections.Generic;

namespace Desafio.Domain
{
    public class Calculate : ICalculate
    {
        public List<int> CalculateAllDivisorsNumber(int number)
        {
            var auxNumber = number;
            var divisorsNumber = new List<int>();
            while (auxNumber > 0)
            {
                if(number%auxNumber == 0)
                {
                    divisorsNumber.Add(auxNumber);
                }
                auxNumber--;
            }
            divisorsNumber.Sort((a, b) => a.CompareTo(b));

            return divisorsNumber;
        }

        public List<int> CalculateAllPrimeDivisorsNumber(int number)
        {
            var divisorsNumber = CalculateAllDivisorsNumber(number);
            var primeNumber = new List<int>();
            
            foreach (var divisorNumber in divisorsNumber)
            {
                var divisor = 2;
                var isNotPrime = false;

                while (divisorNumber > divisor)
                {
                    if (divisorNumber % divisor == 0)
                    {
                        isNotPrime = true;
                        break;
                    }
                    divisor++;
                }

                if (!isNotPrime)
                {
                    primeNumber.Add(divisorNumber);
                }
            }
            return primeNumber;
        }
    }
}
