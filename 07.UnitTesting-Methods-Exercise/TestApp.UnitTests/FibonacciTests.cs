using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        // Arrange
        int input = 0;
        int exected = 0;

        // Act
        int result = Fibonacci.CalculateFibonacci(input);

        // Assert
        Assert.AreEqual(exected, result);
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        // Arange
        int input = 9;
        int exected = 34;

        // Act
        int result = Fibonacci.CalculateFibonacci(input);

        // Assert
        Assert.That(result, Is.EqualTo(exected));
    }
}