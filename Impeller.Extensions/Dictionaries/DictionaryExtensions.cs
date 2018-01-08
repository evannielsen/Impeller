using System;
using System.Collections.Generic;
using System.Text;

namespace Impeller.Extensions.Dictionaries
{
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Adds or Replaces a value for a given key.
        /// </summary>
        /// <typeparam name="TKey">The type of the key to add or replace.</typeparam>
        /// <typeparam name="TValue">The type of the value to populate for the key.</typeparam>
        /// <param name="dictionary">The dictionary to search.</param>
        /// <param name="key">The key to add or replace.</param>
        /// <param name="value">The value to populate for the key.</param>
        public static void AddOrReplace<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            if (dictionary == null)
            {
                return;
            }

            if (dictionary.ContainsKey(key))
            {
                dictionary[key] = value;
            }
            else
            {
                dictionary.Add(key, value);
            }
        }
    }
}
