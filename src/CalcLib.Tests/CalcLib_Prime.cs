using Xunit;
using DevOpsTraining.CalcLib;

namespace DevOpsTraining.CalcLib.Tests;

public class CalcTests_Prime
{
    private readonly Calculator _calc;

    public CalcTests_Prime()
    {
        _calc = new Calculator();
    }

    [InlineData(0, false)]    
    [InlineData(1, false)]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [Theory]
    public void IsPrime_IsNaturalBiggerThan2(int n, bool expected) 
    {
        var result = _calc.IsPrime(n);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void IsPrime_True()
    {
        // Arrange
        var n = 2;

        // Act
        var result = _calc.IsPrime(n);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPrime_False()
    {
        // Arrange
        var n = 6;

        // Act
        var result = _calc.IsPrime(n);

        // Assert
        Assert.False(result);
    }

    [InlineData(2)]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    [Theory]
    public void IsPrime_IsPrime(int n)
    {
        // Arrange

        // Act
        var result = _calc.IsPrime(n);

        // Assert
        Assert.True(result);
    }


    [InlineData(4)]
    [InlineData(6)]
    [InlineData(9)]
    [Theory]
    public void IsPrime_NotPrime(int n)
    {
        // Arrange

        // Act
        var result = _calc.IsPrime(n);

        // Assert
        Assert.False(result);
    }




}