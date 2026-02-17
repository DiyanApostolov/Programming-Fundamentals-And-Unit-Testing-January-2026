using NUnit.Framework;

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        // Arrange
        int[] inputArray = new int[] { 1, 2, 1, 7, 3, 4, 12, 10, 15, 12 };
        int[] expected = new int[] { 1, 15, 2, 12, 3, 10, 4, 7 };

        // Act
        int[] result = Pattern.SortInPattern(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int[] result = Pattern.SortInPattern(emptyArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] inputArray = new int[] { 42 };

        // Act
        int[] result = Pattern.SortInPattern(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(inputArray));
    }
}
