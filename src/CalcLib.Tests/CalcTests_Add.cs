using Xunit;
using DevOpsTraining.CalcLib;

namespace DevOpsTraining.CalcLib.Tests;

public class CalcTests_Add
{
    private readonly Calculator _calc;

    public CalcTests_Add()
    {
        _calc = new Calculator();
    }

    [Fact]
    public void Add_FixNumbers()
    {
        // Arrange
        var a = 1;
        var b = 2;
        var expectedResult = 3;

        // Act
        var result = _calc.Add(a, b);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [InlineData(1, 1, 2)]
    [InlineData(1, 2, 3)]
    [InlineData(2, 1, 3)]
    [InlineData(2, 2, 4)]
    [Theory]
    public void Add_PositiveNumbers(int a, int b, int expectedResult)
    {
        // Arrange
        var expected = expectedResult;

        // Act
        var actual = _calc.Add(a, b);

        // Assert
        Assert.Equal(expected, actual);
    }

    [InlineData(-1, -1)]
    [InlineData(-1, -2)]
    [InlineData(-2, -1)]
    [InlineData(-2, -2)]
    [Theory]
    public void Add_NegativeNumbers(int a, int b)
    {
        // Arrange
        var expected = a + b;

        // Act
        var actual = _calc.Add(a, b);

        // Assert
        Assert.Equal(expected, actual);
    }

    [InlineData(-1, 1)]
    [InlineData(1, -1)]
    [InlineData(-1, 2)]
    [InlineData(1, -2)]
    [InlineData(-2, 1)]
    [InlineData(2, -1)]
    [InlineData(-2, 2)]
    [InlineData(2, -2)]
    [Theory]
    public void Add_MixSignalNumbers(int a, int b)
    {
        // Arrange
        var expected = a + b;

        // Act
        var actual = _calc.Add(a, b);

        // Assert
        Assert.Equal(expected, actual);
    }
}