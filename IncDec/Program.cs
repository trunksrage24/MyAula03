﻿using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = -5, c;
            c = a++ + b++;
            Console.WriteLine(c);

            int d = 2, e = -5, f;
            f = --d + --e;
            Console.WriteLine(f);
        }
    }
}