﻿using System;

namespace bisection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = { 1, 2, 3,4,5,6,7,8,9,10 };
            Console.WriteLine(Utility.Search(s, 7));
        }
    }
}
