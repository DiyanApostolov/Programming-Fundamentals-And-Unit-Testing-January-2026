using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class TopIntegersTests
{
    private TopIntegers topInt;

    [SetUp]
    public void SetUp()
    {
        topInt = new TopIntegers(); // нова инстанция на класа TopIntegers
    }

    [Test]
    public void Test_FindTopIntegers_EmptyArrayParameter_ReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        string result = topInt.FindTopIntegers(emptyArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindTopIntegers_AllElementsAreTopIntegers_ReturnStringWithAllElements()
    {
        // Arrange
        int[] inputArray = new int[] { 17, 9, 6, 2 };
        string expected = "17 9 6 2";

        // Act
        string result = topInt.FindTopIntegers(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_OnlyOneElementArray_ReturnStringWithOneInteger()
    {
        // Arrange
        int[] inputArray = new int[] { 42 };
        string expected = "42";

        // Act
        string result = topInt.FindTopIntegers(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_OnlySomeElementsAreTopIntegers_ReturnStringWithOnlyTopIntegers()
    {
        // Arrange
        int[] inputArray = new int[] { 3, 37, 9, 16, 12, 15 };
        string expected = "37 16 15";

        // Act
        string result = topInt.FindTopIntegers(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // BOUNS TEST: NOT FOT JUDGE!!!
    [Test]
    public void Test_FindTopIntegers_SameElementsArray_ReturnStringWithOneInteger()
    {
        // Arrange
        int[] inputArray = new int[] { 42, 42, 42, 42, 42, 42 };
        string expected = "42";

        // Act
        string result = topInt.FindTopIntegers(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

