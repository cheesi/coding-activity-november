using System.Text;

namespace Refucktoring
{
    internal class Dummy1
    {
        static int[] MoreStupidEveryThing = new int[]
        {
            0b01111010, 69, 70, 0x69, 420, 666
        };

        public static string Dummy1Method()
        {
            var data = ((char)MoreStupidEveryThing[2]).ToString() + (char)MoreStupidEveryThing[3] + (char)MoreStupidEveryThing[0] + (char)MoreStupidEveryThing[0];
            return data;
        }
    }
}
