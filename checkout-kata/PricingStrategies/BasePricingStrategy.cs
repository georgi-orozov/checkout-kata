using checkout_kata.Interfaces;

namespace checkout_kata.PricingStrategies;

public class BasePricingStrategy : IPricingStrategy
{
    private readonly int _singlePrice;

    public BasePricingStrategy(int singlePrice)
    {
        _singlePrice = singlePrice;
    }

    public int CalculatePrice(int itemQuantity)
    {
        return itemQuantity * _singlePrice;
    }
}