using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odd.Maths.Convert
{

    /// <summary>
    /// Converts an Area supplied in mm² into another unit system, with optional deciaml precision.
    /// </summary>
    /// <example>
    ///     <code>
    ///         double length = 100;
    ///         double width = 20;
    ///         double area = length * height;
    ///         Odd.UnitConvert.ToCentemetres(area, 2);
    ///     </code>
    /// </example>
    public static class Area
    {
        /// <summary>
        /// Takes an Area value in mm² and converts it to Centimetres²
        /// </summary>
        /// <param name="area">An area in mm²</param>
        /// <returns>Area in Centimetres²</returns>
        public static double ToCentemetres(double area)
        {
            double _area = area / (ConversionFactors.mmToCm * ConversionFactors.mmToCm);
            return (_area);
        }

        /// <summary>
        /// Takes an Area value in mm² and converts it to Centemetres² with the specified precision
        /// </summary>
        /// <param name="area">An area in mm²</param>
        /// <param name="precision">Number of decimal places to round the return value too.</param>
        /// <returns>Area in Centemetres² rounded to n precision</returns>
        public static double ToCentemetres(double area, int precision)
        {
            double _area = area / (ConversionFactors.mmToCm * ConversionFactors.mmToCm);
            return Math.Round(_area, precision);
        }


        /// <summary>
        /// Takes an Area value in mm² and converts it to Metres
        /// </summary>
        /// <param name="area">An area in mm²</param>
        /// <returns>Area in Metres²</returns>
        public static double ToMetres(double area)
        {
            double _area = area / (ConversionFactors.mmToMetre * ConversionFactors.mmToMetre);
            return (_area);
        }

        /// <summary>
        /// Takes an Area value in mm² and converts it to Metres² with the specified precision
        /// </summary>
        /// <param name="area">An area in mm²</param>
        /// <param name="precision">Number of decimal places to round the return value too.</param>
        /// <returns>Area in Metres² rounded to n precision</returns>
        public static double ToMetres(double area, int precision)
        {
            double _area = area / (ConversionFactors.mmToMetre * ConversionFactors.mmToMetre);
            return Math.Round(_area, precision);
        }


        /// <summary>
        /// Takes an Area value in mm² and converts it to Inches²
        /// </summary>
        /// <param name="area">An area in mm²</param>
        /// <returns>Area in Inches²</returns>
        public static double ToInches(double area)
        {
            double _area = area / (ConversionFactors.mmToInch * ConversionFactors.mmToInch);
            return (_area);
        }

        /// <summary>
        /// Takes an Area value in mm² and converts it to Inches² with the specified precision
        /// </summary>
        /// <param name="area">An area in mm²</param>
        /// <param name="precision">Number of decimal places to round the return value too.</param>
        /// <returns>Area in Inches² rounded to n precision</returns>
        public static double ToInches(double area, int precision)
        {
            double _area = area / (ConversionFactors.mmToInch * ConversionFactors.mmToInch);
            return Math.Round(_area, precision);
        }


        /// <summary>
        /// Takes an Area value in mm² and converts it to Feet²
        /// </summary>
        /// <param name="value">An area in mm²</param>
        /// <returns>Area in Feet²</returns>
        public static double ToFeet(double value)
        {
            double _value = value / (ConversionFactors.mmToFoot * ConversionFactors.mmToFoot);
            return (_value);
        }

        /// <summary>
        /// Takes an Area value in mm² and converts it to Feet² with the specified precision
        /// </summary>
        /// <param name="area">An area in mm²</param>
        /// <param name="precision">Number of decimal places to round the return value too.</param>
        /// <returns>Area in Feet² rounded to n precision</returns>
        public static double ToFeet(double value, int precision)
        {
            double _value = value / (ConversionFactors.mmToFoot * ConversionFactors.mmToFoot);
            return Math.Round(_value, precision);
        }


        /// <summary>
        /// Takes an Area value in mm² and converts it to Points²
        /// </summary>
        /// <param name="area">An area in mm²</param>
        /// <returns>Area in Points²</returns>
        public static double ToPoints(double area)
        {
            double _area = area * (ConversionFactors.mmToPoint * ConversionFactors.mmToPoint);
            return (_area);
        }

        /// <summary>
        /// Takes an Area value in mm² and converts it to Points² with the specified precision
        /// </summary>
        /// <param name="area">An area in mm²</param>
        /// <param name="precision">Number of decimal places to round the return value too.</param>
        /// <returns>Area in Points² rounded to n precision</returns>
        public static double ToPoints(double area, int precision)
        {
            double _area = area * (ConversionFactors.mmToPoint * ConversionFactors.mmToPoint);
            return Math.Round(_area, precision);
        }


        /// <summary>
        /// Takes an Area value in mm² and converts it to Picas²
        /// </summary>
        /// <param name="area">An area in mm²</param>
        /// <returns>Area in Picas²</returns>
        public static double ToPicas(double area)
        {
            double _area = area * (ConversionFactors.mmToPica * ConversionFactors.mmToPica);
            return (_area);
        }

        /// <summary>
        /// Takes an Area value in mm² and converts it to Picas² with the specified precision
        /// </summary>
        /// <param name="area">An area in mm²</param>
        /// <param name="precision">Number of decimal places to round the return value too.</param>
        /// <returns>Area in Picas² rounded to n precision</returns>
        public static double ToPicas(double area, int precision)
        {
            double _area = area * (ConversionFactors.mmToPica * ConversionFactors.mmToPica);
            return Math.Round(_area, precision);
        }

    }
}
