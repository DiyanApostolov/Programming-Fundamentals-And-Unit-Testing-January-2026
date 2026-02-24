using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class NumberProcessorTests
{
    [Test]
    public void Test_ProcessNumbers_SquareEvenNumbers()
    {
        // Arrange
        List<int> input = new() { 2, 4, 6 };
        List<double> expected = new() { 4, 16, 36 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_SquareRootOddNumbers()
    {
        // Arrange
        List<int> input = new() { 9, 49, 11 };
        List<double> expected = new() { 3, 7, 3.316 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected).Within(0.01));
        // .Within(0.01)  -> сравнява числава в листа до втория знак след десетичната запетая
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_HandleZero()
    {
        // Arrange
        List<int> input = new() { 0 };
        List<double> expected = new() { 0 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ProcessNumbers_EmptyInput()
    {
        // Arrange
        List<int> input = new();

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        // Assert
        Assert.That(result, Is.Empty);
    }
}
