using System;
using System.Collections.Generic;
using System.Text;

namespace Impeller.Extensions.Uris
{
    public static class UriExtensions
    {
        /// <summary>
        /// Combines two URIs into a single URI.
        /// </summary>
        /// <param name="left">The left side of the URI.</param>
        /// <param name="right">The right side of the URI.</param>
        /// <returns><see cref="Uri">URI</see> that is the combination of the supplied URIs.</returns>
        public static Uri Combine(this Uri left, Uri right)
        {
            var uri = new Uri(left, right);

            return uri;
        }
    }
}
