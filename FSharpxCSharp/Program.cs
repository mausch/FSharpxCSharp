using System;
using FSharpx;
using Microsoft.FSharp.Collections;

namespace FSharpxCSharp {
    internal class Program {
        private static void Main(string[] args) {
            FSharpList<int> a = FSharpList.Create(1, 2, 3);
            Console.WriteLine(a);
        }
    }
}