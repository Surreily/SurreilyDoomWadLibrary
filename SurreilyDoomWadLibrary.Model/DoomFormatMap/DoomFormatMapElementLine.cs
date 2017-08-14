using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurreilyDoomWadLibrary.Wad.DoomFormatMap
{

    /// <summary>
    /// A Doom format map line.
    /// </summary>
    public class DoomFormatMapElementLine
    {

        /// <summary>
        /// The line's starting vertex.
        /// </summary>
        public ushort StartVertex { get; set; }

        /// <summary>
        /// The line's ending vertex.
        /// </summary>
        public ushort EndVertex { get; set; }

        /// <summary>
        /// The flags.
        /// </summary>
        public ushort Flags { get; set; }

        /// <summary>
        /// The action.
        /// </summary>
        public ushort Action { get; set; }

        /// <summary>
        /// The tag.
        /// </summary>
        public ushort Tag { get; set; }

        /// <summary>
        /// The line's right side.
        /// </summary>
        public ushort RightSide { get; set; }

        /// <summary>
        /// The line's left side.
        /// </summary>
        public ushort LeftSide { get; set; }

    }

}
