﻿using System;
using System.Runtime.InteropServices;

namespace Demo
{
    partial class NativeExportsNE
    {
        public const string NativeExportsNE_Binary = "Microsoft.Interop.Tests." + nameof(NativeExportsNE);

        [GeneratedDllImport(NativeExportsNE_Binary, EntryPoint = "sumi")]
        public static partial int Sum(int a, int b);

        [GeneratedDllImport(NativeExportsNE_Binary, EntryPoint = "sumouti")]
        public static partial void Sum(int a, int b, out int c);

        [GeneratedDllImport(NativeExportsNE_Binary, EntryPoint = "sumrefi")]
        public static partial void Sum(int a, ref int b);
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 13;
            int c = NativeExportsNE.Sum(a, b);
            Console.WriteLine($"{a} + {b} = {c}");

            c = 0;
            NativeExportsNE.Sum(a, b, out c);
            Console.WriteLine($"{a} + {b} = {c}");

            c = b;
            NativeExportsNE.Sum(a, ref c);
            Console.WriteLine($"{a} + {b} = {c}");
        }
    }
}
