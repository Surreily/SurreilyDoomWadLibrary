using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurreilyDoomWadLibrary.ElementInterface.Map.DoomFormat
{

    /// <summary>
    /// A Doom format segment (or seg).
    /// </summary>
    public interface ISegment
    {

        /// <summary>
        /// The segment's (or seg's) starting vertex.
        /// </summary>
        short StartVertex { get; set; }

        /// <summary>
        /// The segment's (or seg's) ending vertex.
        /// </summary>
        short EndVertex { get; set; }

        /// <summary>
        /// The segment's (or seg's) angle.
        /// </summary>
        short Angle { get; set; }

        /// <summary>
        /// The segment's (or seg's) line (or linedef).
        /// </summary>
        short Line { get; set; }

        /// <summary>
        /// The segment's (or seg's) direction.
        /// </summary>
        short Direction { get; set; }

        /// <summary>
        /// The segment's (or seg's) offset.
        /// </summary>
        short Offset { get; set; }

    }

}
