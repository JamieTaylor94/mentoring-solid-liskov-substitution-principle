using NUnit.Framework;

namespace Mentoring.Solid.LiskovSubstitutionPrinciple.Tests
{
    public class SumCalculatorTests
    {

        /*
         *
         * The Liskov substitution principle is following a pattern where higher order classes (otherwise known as base classes/a class you are inheriting from, a super class or a parent class) can be substituted for a derived class without changing the behaviour.
         *
         * The example failing test below shows that when defining a variable of type SumCalculator when instantiating the EvenSumCalculator class the result from the Calculate method uses
         * the calculation in the SumCalculator class meaning the result is giving 40 (all added together) rather than the sum of all even numbers (18). This is because the SumCalculator which
         * is being used as a base class takes order of precedence over the EvenSumCalculator class.
         *
         * To fix this we need to correctly implement the Liskov substitution principle.
         *
         */

        [Test]
        public void SumCalculator_ReturnsAllNumbersAddedTogether()
        {
            // Arrange
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };
            SumCalculator sumCalculator = new SumCalculator(numbers);

            // Act
            var result = sumCalculator.Calculate();

            // Assert
            Assert.AreEqual(40, result);
        }


        [Test]
        public void EvenNumbersSumCalculator_ReturnsEvenNumbersAddedTogether()
        {
            // Arrange
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

            EvenNumbersSumCalculator evenNumbersSumCalculator = new EvenNumbersSumCalculator(numbers);

            // Act
            var sound = evenNumbersSumCalculator.Calculate();

            // Assert
            Assert.AreEqual(18, sound);
        }

        [Test]
        public void EvenNumbersSumCalculator_SubstitutedWith_HigherOrderClass_ReturnsEvenNumbersAddedTogether()
        {
            // Arrange
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

            SumCalculator sumCalculator = new EvenNumbersSumCalculator(numbers);
            
            // Act
            var sound = sumCalculator.Calculate();

            // Assert
            Assert.AreEqual(18, sound);
        }
    }
}
