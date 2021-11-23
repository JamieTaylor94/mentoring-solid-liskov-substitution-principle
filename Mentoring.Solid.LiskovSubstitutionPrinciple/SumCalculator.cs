using System.Linq;

namespace Mentoring.Solid.LiskovSubstitutionPrinciple
{
    public class SumCalculator
    {
        protected readonly int[] Numbers;
        public SumCalculator(int[] numbers)
        {
            Numbers = numbers;
        }
        public int Calculate() => Numbers.Sum();
    }
}