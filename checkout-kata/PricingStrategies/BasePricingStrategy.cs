using checkout_kata.Exceptions;
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
        if (_singlePrice == 0) throw new CustomException("Price cannot be 0");
        
        return itemQuantity * _singlePrice;
    }
}