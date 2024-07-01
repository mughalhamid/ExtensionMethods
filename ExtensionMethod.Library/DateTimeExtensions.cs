using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.Library
{
    public static class DateTimeExtensions
    {
        public static string ToFriendlyString(this DateTime dateTime)
        {
            return dateTime.Humanize();
        }
    }
}
