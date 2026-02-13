using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool result = Email.IsValidEmail(validEmail);

        // Assert - Old Assertion
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrage
        string invalidEmail = "dido@";

        // Act
        bool result = Email.IsValidEmail(invalidEmail);

        // Assert - New Assertion
        Assert.That(result, Is.False);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrage
        string invalidEmail = null;

        // Act
        bool result = Email.IsValidEmail(invalidEmail);

        // Assert - New Assertion
        Assert.That(result, Is.False);
    }
}
