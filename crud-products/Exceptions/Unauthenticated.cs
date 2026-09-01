namespace crud_products.Exceptions;

public class Unauthenticated : Exception
{
    public Unauthenticated(string? message) : base(message) { }
}