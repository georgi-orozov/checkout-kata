using checkout_kata.Interfaces;

namespace checkout_kata.Checkout;

public class Checkout : ICheckout
{
    private Dictionary<string, IPricingStrategy> _pricingStrategies;
    private Dictionary<string, int> _scannedItems = new();

    public Checkout(Dictionary<string, IPricingStrategy> pricingStrategies)
    {
        _pricingStrategies = pricingStrategies;
    }

    public void Scan(string item)
    {
        throw new NotImplementedException();
    }

    public int GetTotalPrice()
    {
        throw new NotImplementedException();
    }
}