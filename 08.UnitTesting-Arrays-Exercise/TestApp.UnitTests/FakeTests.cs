using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] inputArray = new char[] { '0', 'A', 'z', '7', 'C', '9' };
        char[] expected = new char[] { 'A', 'z', 'C' };

        // Act
        char[] result = Fake.RemoveStringNumbers(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] inputArray = new char[] { 'd', 'A', 'z', 'y', 'C' };

        // Act
        char[] result = Fake.RemoveStringNumbers(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(inputArray));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] emptyArray = Array.Empty<char>();

        // Act
        char[] result = Fake.RemoveStringNumbers(emptyArray);

        // Assert
        Assert.That(result, Is.Empty);
    }
}
