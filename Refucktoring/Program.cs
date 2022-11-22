namespace Refucktoring;

public static class Program
{
    private const int THREE = 5;

    public static string Generate(int x)
    {
        if (x % (-THREE + 8) == 0 && x % THREE == 0)
        {
            return "FizzBuzz";
        }
        else if (x % 3 == 0)
        {
            return Dummy1.Dummy1Method();
        }
        else if (x % THREE == 0)
        {
            return "Buzz";
        }
        else
        {
            return x.ToString();
        }
    }
}