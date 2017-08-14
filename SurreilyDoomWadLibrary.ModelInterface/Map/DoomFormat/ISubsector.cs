using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurreilyDoomWadLibrary.ElementInterface.Map.DoomFormat
{

    /// <summary>
    /// A Doom format subsector.
    /// </summary>
    public interface ISubsector
    {

        /// <summary>
        /// The subsector's segment (or seg) count.
        /// </summary>
        short SegmentCount { get; set; }

        /// <summary>
        /// The subsector's first segment (or seg).
        /// </summary>
        short FirstSegment { get; set; }

    }

}
