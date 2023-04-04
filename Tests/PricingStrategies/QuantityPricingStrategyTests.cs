using System;
using checkout_kata.Exceptions;
using checkout_kata.PricingStrategies;
using Moq;
using Xunit;

namespace Tests.PricingStrategies;

public class QuantityPricingStrategyTests
{
    [Theory]
    [InlineData(50, 3, 130, 2, 100)]
    [InlineData(50, 3, 130, 3, 130)]
    [InlineData(50, 3, 130, 4, 180)]
    [InlineData(30, 2, 45, 1, 30)]
    [InlineData(30, 2, 45, 2, 45)]
    [InlineData(30, 2, 45, 3, 75)]
    public void Should_CalculatePrice_ReturnCorrectPrice(int singlePrice, int promoQuantity, int promoPrice, int actualQuantity, int expectedPrice)
    {
        // Arrange
        var quantityStrategy = new QuantityPricingStrategy(singlePrice, promoQuantity, promoPrice);

        // Act
        
        // Assert
        Assert.Equal(expectedPrice, quantityStrategy.CalculatePrice(actualQuantity));
    }

    [Fact]
    public void Should_CalculatePrice_ThrowExceptionWhenSinglePriceIsZero()
    {
        // Arrange
        var quantityStrategy = new QuantityPricingStrategy(0, It.IsAny<int>(), It.IsAny<int>());
        
        // Act
        Action act = () => quantityStrategy.CalculatePrice(It.IsAny<int>());
        
        // Assert
        var exception = Assert.Throws<NoPriceException>(act);
        Assert.Equal("Price cannot be 0", exception.Message);
    }
}