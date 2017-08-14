using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurreilyDoomWadLibrary.Wad.DoomFormatMap
{

    /// <summary>
    /// A Doom format map sector.
    /// </summary>
    public class DoomFormatMapElementSector
    {

        /// <summary>
        /// The floor height.
        /// </summary>
        public short FloorHeight { get; set; }

        /// <summary>
        /// The ceiling height.
        /// </summary>
        public short CeilingHeight { get; set; }

        /// <summary>
        /// The floor texture.
        /// </summary>
        public string FloorTexture { get; set; }

        /// <summary>
        /// The ceiling textue.
        /// </summary>
        public string CeilingTexture { get; set; }

        /// <summary>
        /// The light level.
        /// </summary>
        public short Light { get; set; }

        /// <summary>
        /// The action.
        /// </summary>
        public ushort Action { get; set; }

        /// <summary>
        /// The tag.
        /// </summary>
        public ushort Tag { get; set; }

    }

}
