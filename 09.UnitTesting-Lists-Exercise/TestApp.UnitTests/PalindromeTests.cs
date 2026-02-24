using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> input = new List<string>() { "aha", "civic", "refer", "deified" };

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.That(result, Is.True);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> input = new();

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> input = new List<string>() { "refer" };

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> input = new List<string>() { "aha", "civic", "refer", "hello" };

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> input = new List<string>() { "aha", "CIvic", "Refer", "dEiFieD" };

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.That(result, Is.True);
    }
}
