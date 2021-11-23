using System.Linq;

namespace Mentoring.Solid.LiskovSubstitutionPrinciple
{
    public class EvenNumbersSumCalculator : SumCalculator
    {
        public EvenNumbersSumCalculator(int[] numbers)
            : base(numbers)
        {
        }
        public new int Calculate() => Numbers.Where(x => x % 2 == 0).Sum();
    }
}