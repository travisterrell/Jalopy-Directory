using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.WebUtilities;

namespace treesap.Extensions
{
    public static class UriExtensions
    {
        /// <summary>
        /// Add a key/vair pair to the QueryString collection of a Uri
        /// </summary>
        /// <param name="url">The Uri to add the QueryString to</param>
        /// <param name="key">The key of the QueryString parameter to add</param>
        /// <param name="value">The value for the associated <paramref name="key"/> of the QueryString parameter to add</param>
        /// <returns>A Uri with a populated QueryString collection for use</returns>
        public static string AddQueryParameter(this string url, string key, string value)
        {
            return QueryHelpers.AddQueryString(url, key, value);
        }
    }
}
