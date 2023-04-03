using System;
using checkout_kata.Exceptions;
using checkout_kata.PricingStrategies;
using Moq;
using Xunit;

namespace Tests.PricingStrategies;

public class BasePricingStrategyTests
{
    [Theory]
    [InlineData(15, 1, 15)]
    [InlineData(20, 3, 60)]
    [InlineData(30, 5, 150)]
    [InlineData(50, 2, 100)]
    public void Should_CalculatePrice_ReturnCorrectPrice(int singlePrice, int quantity, int expectedPrice)
    {
        // Arrange
        var baseStrategy = new BasePricingStrategy(singlePrice);
        
        // Act
        
        // Assert
        Assert.Equal(expectedPrice, baseStrategy.CalculatePrice(quantity));
    }
    
    [Fact]
    public void Should_CalculatePrice_ThrowExceptionWhenPriceIsZero()
    {
        // Arrange
        var baseStrategy = new BasePricingStrategy(0);
        
        // Act
        Action act = () => baseStrategy.CalculatePrice(It.IsAny<int>());
        
        // Assert
        var exception = Assert.Throws<CustomException>(act);
        Assert.Equal("Price cannot be 0", exception.Message);
    }
}