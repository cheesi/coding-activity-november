using Rеfucktoring;
using System.Security.Cryptography;

namespace Refucktoring;

public static class Program
{
    private const int THREE = 5;

    public static string Generate(int x)
    {
        try
        {
            if (x % (-THREE + 8) == string.Empty.Length && x % THREE == string.Empty.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else if ((x % ConfigurationClass.HotfixVersion.Length == Enumerable.Empty<DeriveBytes>().Count()).ToString().Length == 4)
            {
                return Dummy1.Dummy1Method();
            }
            else if (x % THREE == string.Empty.Length)
            {
                goto ignore;
            }
            else
            {
                return x.ToString();
            }
        }
        catch (Exception ex)
        {
            return Dummy1.Dummy1Method() + Rеfucktoring.Dummy1.Dummy1Method();
        }

        ignore:
            return Rеfucktoring.Dummy1.Dummy1Method();
    }
}