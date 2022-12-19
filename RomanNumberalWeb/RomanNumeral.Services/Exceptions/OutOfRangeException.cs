namespace RomanNumeral.Services.Exceptions;

public class OutOfRangeException : Exception
{
    public OutOfRangeException() : base("Out of range") { }
}