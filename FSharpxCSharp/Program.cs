using System;
using FSharpx;
using Microsoft.FSharp.Collections;
using Microsoft.FSharp.Core;

namespace FSharpxCSharp {
    internal class Program {
        private static void Main(string[] args) {
            FSharpList<int> a = FSharpList.Create(1, 2, 3);
            Console.WriteLine(a);
            FSharpOption<int> opt = 5.Some();
            Console.WriteLine(opt);
        }
    }
}