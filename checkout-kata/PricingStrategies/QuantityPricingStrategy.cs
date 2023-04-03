using checkout_kata.Interfaces;

namespace checkout_kata.PricingStrategies;

public class QuantityPricingStrategy : IPricingStrategy
{
    private int _singlePrice;
    private int _promoQuantity;
    private int _promoPrice;

    public QuantityPricingStrategy(int singlePrice, int promoQuantity, int promoPrice)
    {
        _singlePrice = singlePrice;
        _promoQuantity = promoQuantity;
        _promoPrice = promoPrice;
    }

    public int CalculatePrice(int itemQuantity)
    {
        throw new NotImplementedException();
    }
}