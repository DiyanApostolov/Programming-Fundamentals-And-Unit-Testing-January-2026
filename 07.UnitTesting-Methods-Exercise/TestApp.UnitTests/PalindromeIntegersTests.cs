using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.UnitTests;

public class PalindromeIntegersTests
{
    [Test]
    public void Test_FindPalindromes_EmptyList_ReturnsEmptyList()
    {
        // Arrange
        List<int> numbers = new List<int>();

        // Act 
        // вдигам нова инстанцияи на класа, защото метода не е статичен
        PalindromeIntegers pi = new PalindromeIntegers();

        List<int> result = pi.FindPalindromes(numbers);

        // Assert
        CollectionAssert.IsEmpty(result);
    }

    [Test]
    public void Test_FindPalindromes_NoPalindromes_ReturnsEmptyList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 123, 250, 223, 800 };

        // Act 
        // вдигам нова инстанцияи на класа, защото метода не е статичен
        PalindromeIntegers pi = new PalindromeIntegers();

        List<int> result = pi.FindPalindromes(numbers);

        // Assert
        CollectionAssert.IsEmpty(result);
    }

    [Test]
    public void Test_FindPalindromes_OnlySingleDigitsElements_ReturnsSameIntegersList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 7, 3, 6, 1 };

        // Act 
        // вдигам нова инстанцияи на класа, защото метода не е статичен
        PalindromeIntegers pi = new PalindromeIntegers();

        List<int> result = pi.FindPalindromes(numbers);

        // Assert
        CollectionAssert.AreEqual(numbers, result);
    }

    [Test]
    public void Test_FindPalindromes_AllElementsArePalindromes_ReturnsSameIntegersList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 707, 33, 6996, 1001 };

        // Act 
        // вдигам нова инстанцияи на класа, защото метода не е статичен
        PalindromeIntegers pi = new PalindromeIntegers();

        List<int> result = pi.FindPalindromes(numbers);

        // Assert
        CollectionAssert.AreEqual(numbers, result);
    }

    [Test]
    public void Test_FindPalindromes_PalimdromesAndNoPalindromesIntegers_ReturnsOnlyPalindromes()
    {
        // Arrange
        List<int> numbers = new List<int>() { 707, 358, 1996, 1001, 265 };
        List<int> expected = new List<int>() { 707, 1001 };

        // Act 
        // вдигам нова инстанцияи на класа, защото метода не е статичен
        PalindromeIntegers pi = new PalindromeIntegers();

        List<int> result = pi.FindPalindromes(numbers);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
