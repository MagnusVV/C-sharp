using System;
namespace Assignment_3
{
    static class Die
    {
        static readonly Random _random = new();
        public static int Roll() => _random.Next(1, 7);
    }
}

