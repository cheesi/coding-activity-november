using MorseCode.Nuget;
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
            => Refucktoring.Dummy1.Dummy1Method().Replace("F", "B").Replace("i", "u");

        public static string X()
        {
            var x = Morse.ToAlphabet("-...").ToString() + Morse.ToAlphabet("..-") + Morse.ToAlphabet("--..") + Morse.ToAlphabet("--..");
            return char.ToUpper(x[0]) + x.Substring(1);
        }
    }
}
