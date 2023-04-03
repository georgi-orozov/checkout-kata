# checkout-kata

## General info
A console application that includes an implementation of a simple checkout system.

## Initial idea
I decided to implement the strategy design pattern to tackle the pricing problem. It is
a good solution when we need to apply different algorithms at runtime. In my case, I will
add an interface **IPricingStrategy.cs** and two classes that will implement that interface -
**BasePricingStrategy.cs** and **QuantityPricingStrategy.cs**. Thus, I will keep the pricing
logic decoupled from the checkout process. Also, it is easy to add, update and/or 
delete pricing strategies without affecting the rest of the application. Last but not
least, this design pattern will allow me to test each different pricing model in 
isolation. 

```csharp
public interface IPricingStrategy
{
    int CalculatePrice(int itemQuantity);
}
