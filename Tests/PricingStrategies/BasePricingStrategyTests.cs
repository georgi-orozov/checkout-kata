using checkout_kata.PricingStrategies;
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
        var baseStrategy = new BasePricingStrategy(singlePrice);
        
        Assert.Equal(expectedPrice, baseStrategy.CalculatePrice(quantity));
    }
}