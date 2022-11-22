using Refucktoring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rеfucktoring
{
    internal class Dummy1 : Refucktoring.Dummy1
    {
        public static string Dummy1Method()
        {
            return Refucktoring.Dummy1.Dummy1Method().Replace(typeof(Dummy1).Namespace[2].ToString().ToUpper(), "B").Replace("i", "u");

            return Refucktoring.Dummy1.Dummy1Method().Replace("lulululu", "bababababa").Replace("NaNNaNNaNNaNNaN", "Batmaaaaann");
        }
    }
}
