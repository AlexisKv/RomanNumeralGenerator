using System.Text;
using RomanNumeral.Core.Services;
using RomanNumeral.Services.Exceptions;

namespace RomanNumeral.Services;

public class GeneratorServices : IRomanNumeralGenerator
{
    public static Dictionary<int, string> NumberRomanDictionary = new()
    {
        {1000, "M" },
        { 900, "CM" },
        { 500, "D" },
        { 400, "CD" },
        { 100, "C" },
        { 90, "XC"},
        { 50, "L" },
        { 40, "XL" },
        { 10, "X" },
        { 9, "IX" },
        { 5, "V" },
        { 4, "IV" },
        { 1, "I" },
    };
    
    public string Generate(int number)
    {
        if (number is < 1 or > 3999)
        {
            throw new OutOfRangeException();
        }
        
        var roman = new StringBuilder();

        foreach (var item in NumberRomanDictionary)
        {
            while (number >= item.Key)
            {
                roman.Append(item.Value);
                number -= item.Key;
            }
        }
            
        return roman.ToString();
    }
}