using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impeller.Helpers.Random
{
    public static class RandomStringGenerator
    {
        private static readonly System.Random random = new System.Random();

        private const string availableChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public static string GenerateString(int length)
        {
            return new string(
                Enumerable.Repeat(availableChars, length)
                .Select(s => s[random.Next(s.Length)])
                .ToArray()
                );
        }

    }
}
