using checkout_kata.Checkout;
using checkout_kata.Interfaces;
using checkout_kata.PricingStrategies;

// Define pricing strategies
var pricingStrategies = new Dictionary<string, IPricingStrategy>
{
    { "A", new QuantityPricingStrategy(50, 3, 130) },
    { "B", new QuantityPricingStrategy(30, 2, 45) },
    { "C", new BasePricingStrategy(20) },
    { "D", new BasePricingStrategy(15) },
};

// Create a new checkout instance with the pricing strategies
var checkout = new Checkout(pricingStrategies);

// Scan some items
checkout.Scan("B");
checkout.Scan("A");
checkout.Scan("B");
checkout.Scan("C");
checkout.Scan("A");
checkout.Scan("A");
checkout.Scan("D");

// Calculate the total price
var totalPrice = checkout.GetTotalPrice();
Console.WriteLine("Total price: " + totalPrice); // Should be 210