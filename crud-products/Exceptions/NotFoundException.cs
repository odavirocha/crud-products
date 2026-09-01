namespace crud_products.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException(string? message) : base(message) { }
}