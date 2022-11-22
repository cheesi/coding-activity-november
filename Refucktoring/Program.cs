using Rеfucktoring;

namespace Refucktoring;

public static class Program
{
    private const int THREE = 5;

    public static string Generate(int x)
    {
        if (x % (-THREE + 8) == 0 && x % THREE == 0)
        {
            return Dummy1.Dummy1Method() + Rеfucktoring.Dummy1.JKlsedfjk();
        }
        else if (x % 3 == 0)
        {
            return Dummy1.Dummy1Method();
        }
        else if (x % THREE == 0)
        {
            return Rеfucktoring.Dummy1.JKlsedfjk();
        }
        else
        {
            return x.ToString();
        }
    }
}