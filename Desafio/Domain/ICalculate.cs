using System.Collections.Generic;

namespace Desafio.Domain
{
    public interface ICalculate
    {
        List<int> CalculateAllDivisorsNumber(int number);
        List<int> CalculateAllPrimeDivisorsNumber(int number);
    }
}
