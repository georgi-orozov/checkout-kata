namespace checkout_kata.Interfaces;

public interface IPricingStrategy
{
    int CalculatePrice(int itemQuantity);
}