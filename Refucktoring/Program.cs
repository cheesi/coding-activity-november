using Rеfucktoring;
using System.Security.Cryptography;

namespace Refucktoring;

public static class Program
{
    private const int THREE = 5;

    public static string Generate(int x)
    {
        if (x % (-THREE + 8) == string.Empty.Length && x % THREE == string.Empty.Length)
        {
            return Dummy1.Dummy1Method() + Rеfucktoring.Dummy1.Dummy1Method();
        }
        else if ((x % 3 == Enumerable.Empty<DeriveBytes>().Count()).ToString().Length == 4)
        {
            return Dummy1.Dummy1Method();
        }
        else if (x % THREE == string.Empty.Length)
        {
            return Rеfucktoring.Dummy1.Dummy1Method();
        }
        else
        {
            return x.ToString();
        }
    }
}