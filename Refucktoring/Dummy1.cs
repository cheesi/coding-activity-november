using System.Text;

namespace Refucktoring
{
    internal class Dummy1
    {
        static int[] MoreStupidEveryThing = new int[]
        {
            70, 0x69, 0b01111010
        };

        public static string Dummy1Method()
        {
            var data = ((char)MoreStupidEveryThing[0]).ToString() + (char)MoreStupidEveryThing[1] + (char)MoreStupidEveryThing[2] + (char)MoreStupidEveryThing[2];
            return data;
        }
    }
}
