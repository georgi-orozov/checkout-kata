using checkout_kata.Exceptions;
using checkout_kata.Interfaces;

namespace checkout_kata.PricingStrategies;

public class QuantityPricingStrategy : IPricingStrategy
{
    private readonly int _singlePrice;
    private readonly int _promoQuantity;
    private readonly int _promoPrice;

    public QuantityPricingStrategy(int singlePrice, int promoQuantity, int promoPrice)
    {
        _singlePrice = singlePrice;
        _promoQuantity = promoQuantity;
        _promoPrice = promoPrice;
    }

    public int CalculatePrice(int itemQuantity)
    {
        if (_singlePrice == 0) throw new NoPriceException("Price cannot be 0");
        
        var bundles = itemQuantity / _promoQuantity;
        var remainder = itemQuantity % _promoQuantity;
        
        return (bundles * _promoPrice) + (remainder * _singlePrice);
    }
}