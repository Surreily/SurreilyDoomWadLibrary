using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurreilyDoomWadLibrary.Wad.DoomFormatMap
{

    /// <summary>
    /// A Doom format map thing.
    /// </summary>
    public class DoomFormatMapElementThing
    {

        /// <summary>
        /// The X position.
        /// </summary>
        public short X { get; set; }

        /// <summary>
        /// The Y position.
        /// </summary>
        public short Y { get; set; }

        /// <summary>
        /// The angle.
        /// </summary>
        public ushort Angle { get; set; }

        /// <summary>
        /// The type.
        /// </summary>
        public ushort Type { get; set; }

        /// <summary>
        /// The spawn flags.
        /// </summary>
        public ushort Flags { get; set; }

    }

}
