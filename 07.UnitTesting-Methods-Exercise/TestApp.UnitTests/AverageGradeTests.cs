using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class AverageGradeTests
{
    [Test]
    public void Test_GetGradeDefinition_AverageGradeUnderTwo_ReturnsErrorMessage()
    {
        // Arrange
        List<double> grades = new List<double>() { 2.50, 1.20, 1.60 };
        string expected = "Incorrect grades";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades.ToList());

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_AverageGradeOverSix_ReturnsErrorMessage()
    {
        // Arrange
        List<double> grades = new List<double>() { 6.50, 6.00, 6.10 };
        string expected = "Incorrect grades";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(new double[] { 2.00, 2.00, 2.00 })]
    [TestCase(new double[] { 2.50, 2.20, 2.60 })]
    [TestCase(new double[] { 2.99, 2.99, 2.99 })]
    public void Test_GetGradeDefinition_FailScoreAverageGrade_ReturnsFailDefinitionMessage(double[] grades)
    {
        // Arrange
        //List<double> grades = new List<double>() { 2.60, 2.20, 3.00 };
        string expected = "Fail";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades.ToList());

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_PoorScoreAverageGrade_ReturnsPoorDefinitionMessage()
    {
        // Arrange
        List<double> grades = new List<double>() { 3.60, 3.20, 3.00 };
        string expected = "Poor";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_GoodScoreAverageGrade_ReturnsGoodDefinitionMessage()
    {
        // Arrange
        List<double> grades = new List<double>() { 3.60, 4.20, 4.00 };
        string expected = "Good";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_VeryGoodScoreAverageGrade_ReturnsVeryGoodDefinitionMessage()
    {
        // Arrange
        List<double> grades = new List<double>() { 4.60, 5.10, 5.60 };
        string expected = "Very good";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_ExcellentScoreAverageGrade_ReturnsExcellentDefinitionMessage()
    {
        // Arrange
        List<double> grades = new List<double>() { 5.40, 5.70, 6.00 };
        string expected = "Excellent";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
