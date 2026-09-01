namespace crud_products.Exceptions;

public class AlreadyExists : Exception
{
    public AlreadyExists(string message) : base(message) { }
}