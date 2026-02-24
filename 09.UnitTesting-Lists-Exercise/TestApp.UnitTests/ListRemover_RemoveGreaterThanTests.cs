using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveGreaterThanTests
{
    [Test]
    public void Test_RemoveElementsGreaterThan_EmptyListParameter_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new();
        int threshold = 5;

        // Act 
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, threshold);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithGreaterThanThresholdElements_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new() { 6, 13, 28, 9, 7 };
        int threshold = 5;

        // Act 
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, threshold);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanOrEqualToThresholdElements_ReturnsSameList()
    {
        // Arrange
        List<int> input = new() { 3, 2, -6, 0, 5 };
        int threshold = 5;

        // Act 
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, threshold);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyLessThanOrEqualToThreshold()
    {
        // Arrange
        List<int> input = new() { 3, 22, -6, 10, 15, 7, 9, 100 };
        int threshold = 10;
        List<int> exected = new() { 3, -6, 10, 7, 9 };

        // Act 
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, threshold);

        // Assert
        Assert.That(result, Is.EqualTo(exected));
    }
}
