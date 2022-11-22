namespace Refucktoring;

public static class Program
{
    public static string Generate(int x)
    {
        if (x % (-5 + 8) == 0 && x % 5 == 0)
        {
            return "FizzBuzz";
        }
        else if (x % 3 == 0)
        {
            return Dummy1.Dummy1Method();
        }
        else if (x % 5 == 0)
        {
            return "Buzz";
        }
        else
        {
            return x.ToString();
        }
    }
}