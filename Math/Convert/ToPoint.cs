using System;
using Odd.Maths;

namespace Odd.Maths.Convert
{

    public static class ConversionExtensionMethods
    {
        /// <summary>
        /// Takes a Length or Area and converts it to Points
        /// </summary>
        /// <param name="d">A double number</param>
        /// <param name="fromUnit">The unit of the supplied value, only "mm", "cm", "m", "in", "ft" & "pica" are supported, all other values will return a 0 value.</param>
        /// <param name="precision">Number of decimal places to round the return value too.</param>
        /// <param name="isArea">Bool: is the number to be converted an Area value, "true" if it is</param>
        /// <returns>A Length or an Area in points (or points²).</returns>
        public static double ToPoints(this double d, string fromUnit = "mm", int precision = 2, bool isArea = false)
        {
            switch (fromUnit)
            {
                case "mm":
                    return (isArea == true)
                        ? Math.Round(d * Math.Pow(ConversionFactors.mmToPoint, 2), precision)
                        : Math.Round(d * ConversionFactors.mmToPoint, precision);
                case "cm":
                    return (isArea == true)
                        ? Math.Round(d * Math.Pow(ConversionFactors.cmToPoint, 2), precision)
                        : Math.Round(d * ConversionFactors.cmToPoint, precision);
                case "m":
                    return (isArea == true)
                        ? Math.Round(d * Math.Pow(ConversionFactors.mToPoint, 2), precision)
                        : Math.Round(d * ConversionFactors.mToPoint, precision);
                case "in":
                    return (isArea == true)
                        ? Math.Round(d * Math.Pow(ConversionFactors.inToPoint, 2), precision)
                        : Math.Round(d * ConversionFactors.inToPoint, precision);
                case "ft":
                    return (isArea == true)
                        ? Math.Round(d * Math.Pow(ConversionFactors.ftToPoint, 2), precision)
                        : Math.Round(d * ConversionFactors.ftToPoint, precision);
                case "pc":
                    return (isArea == true)
                        ? Math.Round(d * Math.Pow(ConversionFactors.picaToPoint, 2), precision)
                        : Math.Round(d * ConversionFactors.picaToPoint, precision);
                default:
                    //Returns 0 if an incorrect fromUnit unit is specified
                    return 0;
            }

        }

    }
}