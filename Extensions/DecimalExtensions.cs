using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// DecimalExtensions.cs

using System.Globalization;

namespace InForno.Extensions
{
    public static class DecimalExtensions
    {
        public static string ToEuroCurrency(this decimal value)
        {
            // Usa "C" per il formato di valuta e specifica la cultura italiana
            return value.ToString("C", CultureInfo.GetCultureInfo("it-IT"));
        }
    }
}
