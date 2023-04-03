using checkout_kata.Interfaces;

namespace checkout_kata.PricingStrategies;

public class BasePricingStrategy : IPricingStrategy
{
    private int _singlePrice;

    public BasePricingStrategy(int singlePrice)
    {
        _singlePrice = singlePrice;
    }

    public int CalculatePrice(int itemQuantity)
    {
        throw new NotImplementedException();
    }
}