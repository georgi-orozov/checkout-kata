namespace checkout_kata.Exceptions;

public class MultipleItemsScannedException : Exception
{
    public MultipleItemsScannedException()
    {
        
    }

    public MultipleItemsScannedException(string message)
        : base(message)
    {
        
    }
    
}