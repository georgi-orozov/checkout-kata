using System;
using System.Collections.Generic;
using checkout_kata.Exceptions;
using checkout_kata.Interfaces;
using checkout_kata.PricingStrategies;
using Xunit;

namespace Tests.Checkout;

public class CheckoutTests
{

    [Theory]
    [InlineData(new[] { "A" }, 50)]
    [InlineData(new[] { "B" }, 30)]
    [InlineData(new[] { "C" }, 20)]
    [InlineData(new[] { "D" }, 15)]
    public void Should_GetTotalPrice_ReturnCorrectPriceForSingleItem(string[] items, int expectedPrice)
    {
        // Arrange
        var checkout = new checkout_kata.Checkout.Checkout(GetPricingStrategies());
        
        // Act
        foreach (var item in items)
        {
            checkout.Scan(item);
        }

        // Assert
        Assert.Equal(expectedPrice, checkout.GetTotalPrice());
    }
    
    [Theory]
    [InlineData(new[] { "B", "A", "B", "C", "A", "A", "D" }, 225)]
    [InlineData(new[] { "A", "A", "A", "A", "A" }, 230)]
    [InlineData(new[] { "B", "B", "B" }, 75)]
    [InlineData(new[] { "A", "B", "D" }, 95)]
    public void Should_GetTotalPrice_ReturnCorrectPriceForMultipleItem(string[] items, int expectedPrice)
    {
        // Arrange
        var checkout = new checkout_kata.Checkout.Checkout(GetPricingStrategies());
        
        // Act
        foreach (var item in items)
        {
            checkout.Scan(item);
        }

        // Assert
        Assert.Equal(expectedPrice, checkout.GetTotalPrice());
    }
    
    [Fact]
    public void Should_GetTotalPrice_ThrowsExceptionWhenNoScanItems()
    {
        // Arrange
        var checkout = new checkout_kata.Checkout.Checkout(GetPricingStrategies());
        
        // Act
        Action act = () => checkout.GetTotalPrice();

        // Assert
        var exception = Assert.Throws<CustomException>(act);
        Assert.Equal("No items scanned", exception.Message);
    }
    
    [Fact]
    public void Should_Scan_ThrowsExceptionWhenMultipleItems()
    {
        // Arrange
        var checkout = new checkout_kata.Checkout.Checkout(GetPricingStrategies());
        
        // Act
        Action act = () => checkout.Scan("AB");

        // Assert
        var exception = Assert.Throws<CustomException>(act);
        Assert.Equal("Only 1 item at a time", exception.Message);
    }
    
    
    private Dictionary<string, IPricingStrategy> GetPricingStrategies()
    {
        return new Dictionary<string, IPricingStrategy>
        {
            { "A", new QuantityPricingStrategy(50, 3, 130) },
            { "B", new QuantityPricingStrategy(30, 2, 45) },
            { "C", new BasePricingStrategy(20) },
            { "D", new BasePricingStrategy(15) },
        };
    }
}