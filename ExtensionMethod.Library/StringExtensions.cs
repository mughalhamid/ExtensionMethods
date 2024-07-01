using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.Library
{
    public static class StringExtensions
    {
        public static string ToTitleCase(this string @string)
        {
            return @string.Titleize();
        }
    }
}
