namespace checkout_kata.Exceptions;

public class NoScannedItemsException : Exception
{
    public NoScannedItemsException()
    {
        
    }

    public NoScannedItemsException(string message)
        : base(message)
    {
        
    }
    
}