using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurreilyDoomWadLibrary.ElementInterface.Map.DoomFormat
{

    /// <summary>
    /// A Doom format line (or linedef).
    /// </summary>
    public interface ILine
    {

        /// <summary>
        /// The line's starting vertex.
        /// </summary>
        short StartVertex { get; set; }

        /// <summary>
        /// The line's ending vertex.
        /// </summary>
        short EndVertex { get; set; }

        /// <summary>
        /// The line's flags.
        /// </summary>
        short Flags { get; set; }

        /// <summary>
        /// The line's special action.
        /// </summary>
        short Action { get; set; }

        /// <summary>
        /// The line's tag. 2 bytes.
        /// </summary>
        short Tag { get; set; }

        /// <summary>
        /// The line's front side (or sidedef).
        /// </summary>
        short FrontSide { get; set; }

        /// <summary>
        /// The line's back side (or sidedef).
        /// </summary>
        short BackSide { get; set; }

    }
}
