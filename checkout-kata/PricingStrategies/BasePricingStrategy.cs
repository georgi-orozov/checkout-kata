using checkout_kata.Interfaces;

namespace checkout_kata.PricingStrategies;

public class BasePricingStrategy : IPricingStrategy
{
    public int CalculatePrice(int itemQuantity)
    {
        throw new NotImplementedException();
    }
}