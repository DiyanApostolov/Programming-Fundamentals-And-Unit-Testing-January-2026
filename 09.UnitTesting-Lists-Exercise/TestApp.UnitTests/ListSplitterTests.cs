using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListSplitterTests
{
    [Test]
    public void Test_SplitEvenAndOdd_EmptyListParameter_ReturnsEmptyEvenAndOddLists()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        (List<int> evens, List<int> odds) result = ListSplitter.SplitEvenAndOdd(emptyList);

        // Assert
        Assert.That(result.evens, Is.Empty);
        Assert.That(result.odds, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyEvenValues_ReturnsEmptyOddList()
    {
        // Arrange
        List<int> input = new() { 2, 8, 18, 4 };

        // Act
        (List<int> evens, List<int> odds) result = ListSplitter.SplitEvenAndOdd(input);

        // Assert
        Assert.That(result.odds, Is.Empty);
        Assert.That(result.evens, Is.EqualTo(input));
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyOddValues_ReturnsEmptyEvenList()
    {
        // Arrange
        List<int> input = new() { 3, 7, 19, 21, -5 };

        // Act
        (List<int> evens, List<int> odds) result = ListSplitter.SplitEvenAndOdd(input);

        // Assert
        Assert.That(result.odds, Is.EqualTo(input));
        Assert.That(result.evens, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_EvenAndOddValues_ReturnsListWithCorrectValues()
    {
        // Arrange
        List<int> input = new() { 3, 7, 10, 21, 6, 128, -3, 0 };
        List<int> expectedEvens = new() { 10, 6, 128, 0 };
        List<int> expectedOdds = new() { 3, 7, 21, -3 };

        // Act
        (List<int> evens, List<int> odds) result = ListSplitter.SplitEvenAndOdd(input);

        // Assert
        Assert.That(result.evens, Is.EqualTo(expectedEvens));
        Assert.That(result.odds, Is.EqualTo(expectedOdds));
    }
}
