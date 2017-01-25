using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odd.Maths.Convert
{
    /// <summary>
    /// Converts a Length supplied in mm into another unit system
    /// </summary>
    /// <example>
    ///     <code>
    ///         double metre = 1000;
    ///         Odd.UnitConvert.ToCentemetres(metre, 2);
    ///     </code>
    /// </example>
    public static class Length
    {
        /// <summary>
        /// Takes a Length value in mm and converts it to Centimetres
        /// </summary>
        /// <param name="value">A length in mm</param>
        /// <returns>Length in Centimetres</returns>
        public static double ToCentemetres(double length)
        {
            double _length = length / ConversionFactors.mmToCm;
            return (_length);
        }

        /// <summary>
        /// Takes a Length value in mm and converts it to Centimetres to the specified precision
        /// </summary>
        /// <param name="length">A length in mm</param>
        /// <param name="precision">Number of decimal places to round the return value too.</param>
        /// <returns>Length in Centemetres rounded to n precision</returns>
        public static double ToCentemetres(double length, int precision)
        {
            double _length = length / ConversionFactors.mmToCm;
            return Math.Round(_length, precision);
        }


        /// <summary>
        /// Takes a Length value in mm and converts it to Metres
        /// </summary>
        /// <param name="length">A length in mm</param>
        /// <returns>Length in Metres</returns>
        public static double ToMetres(double length)
        {
            double _length = length / ConversionFactors.mmToMetre;
            return (_length);
        }

        /// <summary>
        /// Takes a Length value in mm and converts it to Metres to the specified precision
        /// </summary>
        /// <param name="length">A length in mm</param>
        /// <param name="precision">Number of decimal places to round the return value too.</param>
        /// <returns>Length in Metres rounded to n precision</returns>
        public static double ToMetres(double length, int precision)
        {
            double _length = length / ConversionFactors.mmToMetre;
            return Math.Round(_length, precision);
        }


        /// <summary>
        /// Takes a Length value in mm and converts it to Inches
        /// </summary>
        /// <param name="length">A length in mm</param>
        /// <returns>Length in Inches</returns>
        public static double ToInches(double length)
        {
            double _length = length / ConversionFactors.mmToInch;
            return (_length);
        }

        /// <summary>
        /// Takes a Length value in mm and converts it to Inches to the specified precision
        /// </summary>
        /// <param name="length">A length in mm</param>
        /// <param name="precision">Number of decimal places to round the return value too.</param>
        /// <returns>Length in inches rounded to n precision</returns>
        public static double ToInches(double length, int precision)
        {
            double _length = length / ConversionFactors.mmToInch;
            return Math.Round(_length, precision);
        }


        /// <summary>
        /// Takes a Length value in mm and converts it to Feet
        /// </summary>
        /// <param name="length">A length in mm</param>
        /// <returns>Length in Feet</returns>
        public static double ToFeet(double length)
        {
            double _length = length / ConversionFactors.mmToFoot;
            return (_length);
        }

        /// <summary>
        /// Takes a Length value in mm and converts it to Feet to the specified precision
        /// </summary>
        /// <param name="length">A length in mm</param>
        /// <param name="precision">Number of decimal places to round the return value too.</param>
        /// <returns>Length in feet rounded to n precision</returns>
        public static double ToFeet(double length, int precision)
        {
            double _length = length / ConversionFactors.mmToFoot;
            return Math.Round(_length, precision);
        }


        /// <summary>
        /// Takes a Length value in mm and converts it to Points
        /// </summary>
        /// <param name="length">A length in mm</param>
        /// <returns>Length in Points</returns>
        public static double ToPoints(double length)
        {
            double _length = length * ConversionFactors.mmToPoint;
            return (_length);
        }

        /// <summary>
        /// Takes a Length value in mm and converts it to Points to the specified precision
        /// </summary>
        /// <param name="length">A length in mm</param>
        /// <param name="precision">Number of decimal places to round the return value too.</param>
        /// <returns>Length in Points rounded to n precision</returns>
        public static double ToPoints(double length, int precision)
        {
            double _length = length * ConversionFactors.mmToPoint;
            return Math.Round(_length, precision);
        }

        /// <summary>
        /// Takes a Length value in mm and converts it to Picas
        /// </summary>
        /// <param name="length">A length in mm</param>
        /// <returns>Length in Picas</returns>
        public static double ToPicas(double length)
        {
            double _length = length * ConversionFactors.mmToPica;
            return (_length);
        }

        /// <summary>
        /// Takes a Length value in mm and converts it to Picas to the specified precision
        /// </summary>
        /// <param name="length">A length in mm</param>
        /// <param name="precision">Number of decimal places to round the return value too.</param>
        /// <returns>Length in Picas rounded to n precision</returns>
        public static double ToPicas(double length, int precision)
        {
            double _length = length * ConversionFactors.mmToPica;
            return Math.Round(_length, precision);
        }

    }
}
