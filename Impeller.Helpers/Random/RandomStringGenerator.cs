using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impeller.Helpers.Random
{
    /// <summary>
    /// Class to generate a random string.
    /// </summary>
    public static class RandomStringGenerator
    {
        private static readonly System.Random random = new System.Random();

        private const string availableChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        /// <summary>
        /// Generates a random string of a given length.
        /// </summary>
        /// <param name="length">The desired length of the string.</param>
        /// <returns></returns>
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
