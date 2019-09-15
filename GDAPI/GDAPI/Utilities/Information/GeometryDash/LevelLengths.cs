﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDAPI.Utilities.Information.GeometryDash
{
    /// <summary>Contains the constants for the lengths</summary>
    public static class LevelLengths
    {
        /// <summary>The minimum time length for the XL level length.</summary>
        public const double MinXLLength = 120;
        /// <summary>The minimum time length for the Long level length.</summary>
        public const double MinLongLength = 60;
        /// <summary>The minimum time length for the Medium level length.</summary>
        public const double MinMediumLength = 30;
        /// <summary>The minimum time length for the Small level length.</summary>
        public const double MinSmallLength = 10;
        /// <summary>The minimum time length for the Tiny level length.</summary>
        public const double MinTinyLength = 0;

        /// <summary>The maximum time length for the XL level length.</summary>
        public const double MaxXLLength = double.PositiveInfinity;
        /// <summary>The maximum time length for the Long level length.</summary>
        public const double MaxLongLength = 120;
        /// <summary>The maximum time length for the Medium level length.</summary>
        public const double MaxMediumLength = 60;
        /// <summary>The maximum time length for the Small level length.</summary>
        public const double MaxSmallLength = 30;
        /// <summary>The maximum time length for the Tiny level length.</summary>
        public const double MaxTinyLength = 10;

        /// <summary>The time length range for the XL level length.</summary>
        public static readonly Range<double> XLLengthRange = new Range<double>(MinXLLength, MaxXLLength);
        /// <summary>The time length range for the Long level length.</summary>
        public static readonly Range<double> LongLengthRange = new Range<double>(MinLongLength, MaxLongLength);
        /// <summary>The time length range for the Medium level length.</summary>
        public static readonly Range<double> MediumLengthRange = new Range<double>(MinMediumLength, MaxMediumLength);
        /// <summary>The time length range for the Small level length.</summary>
        public static readonly Range<double> SmallLengthRange = new Range<double>(MinSmallLength, MaxSmallLength);
        /// <summary>The time length range for the Tiny level length.</summary>
        public static readonly Range<double> TinyLengthRange = new Range<double>(MinTinyLength, MaxTinyLength);
    }
}
