using System;
using Systembolaget.DataObjects;

namespace Systembolagskollen.Helpers
{
    public static class BeverageHelper
    {
        public static decimal AlcoholToDecimal(this Beverage source)
        {
            var alcohol = source.Alcohol;
            alcohol = alcohol.Replace(".", ",");
            alcohol = alcohol.Replace("%", "");

            return Convert.ToDecimal(alcohol);
        }

        public static decimal PreventZero(this decimal @decimal)
        {
            if (@decimal == 0m)
                return 1m;
            return @decimal;
        }

        public static decimal ToPercentage(this decimal @decimal) => @decimal / 100m;
    }
}
