using System;
using System.Collections.Generic;
using System.Text;

namespace Impeller.Extensions.Dictionaries
{
    public static class DictionaryExtensions
    {
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
