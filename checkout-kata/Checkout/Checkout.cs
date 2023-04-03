using checkout_kata.Exceptions;
using checkout_kata.Interfaces;

namespace checkout_kata.Checkout;

public class Checkout : ICheckout
{
    private Dictionary<string, IPricingStrategy> _pricingStrategies;
    private readonly Dictionary<string, int> _scannedItems = new();

    public Checkout(Dictionary<string, IPricingStrategy> pricingStrategies)
    {
        _pricingStrategies = pricingStrategies;
    }

    public void Scan(string item)
    {
        if (item.Length != 1) throw new CustomException("Only 1 item at a time");
        
        if (_scannedItems.ContainsKey(item))
        {
            _scannedItems[item]++;
        }
        else
        {
            _scannedItems[item] = 1;
        }
    }

    public int GetTotalPrice()
    {
        throw new NotImplementedException();
    }
}