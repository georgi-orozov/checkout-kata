namespace checkout_kata.Exceptions;

public class NoPriceException : Exception
{
    public NoPriceException()
    {
        
    }

    public NoPriceException(string message)
        : base(message)
    {
        
    }
    
}