using Refucktoring;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rеfucktoring
{
    internal class Dummy1 : Refucktoring.Dummy1
    {
        const string alphabet = "asdgjksdivbm,nmdif";

        public static dynamic Dummy1Method()
        {
            return Refucktoring.Dummy1.Dummy1Method().Replace(typeof(Dummy1).Namespace[2].ToString().ToUpper(), alphabet[10].ToString().ToUpper()).Replace(alphabet[8].ToString(), ((char)(alphabet[8]+12)).ToString() );

            return Refucktoring.Dummy1.Dummy1Method().Replace("lulululu", "bababababa").Replace("NaNNaNNaNNaNNaN", "Batmaaaaann");
        }
    }
}
