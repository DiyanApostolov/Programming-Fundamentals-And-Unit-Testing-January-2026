using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        long input = 13;
        long expected = 13;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        // Arrange
        long input = 84;
        long expected = 7;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
