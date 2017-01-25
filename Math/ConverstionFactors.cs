using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odd.Maths
{
    public class ConversionFactors
    {
        public const double mmToPoint   = 2.834645669291;
        public const double cmToPoint   = mmToPoint * mmToCm;
        public const double mToPoint    = mmToPoint * mmToMetre;
        public const double inToPoint   = mmToPoint * mmToInch;
        public const double ftToPoint   = mmToPoint * mmToFoot;
        public const double picaToPoint = 72;

        public const double mmToCm      = 10;
        public const double mmToMetre   = 1000;
        public const double mmToInch    = 25.4;
        public const double mmToFoot    = 304.8;
        public const double mmToPica    = 0.236220471;
    }
}