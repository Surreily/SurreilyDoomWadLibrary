using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurreilyDoomWadLibrary.Wad.DoomFormatMap
{

    /// <summary>
    /// A Doom format map side.
    /// </summary>
    public class DoomFormatMapElementSide
    {

        /// <summary>
        /// The X texture offset.
        /// </summary>
        public short XOffset { get; set; }

        /// <summary>
        /// The Y texture offset.
        /// </summary>
        public short YOffset { get; set; }

        /// <summary>
        /// The upper texture's name.
        /// </summary>
        public string UpperTexture { get; set; }

        /// <summary>
        /// The lower texture's name.
        /// </summary>
        public string LowerTexture { get; set; }

        /// <summary>
        /// The middle texture's name.
        /// </summary>
        public string MiddleTexture { get; set; }

        /// <summary>
        /// The sector.
        /// </summary>
        public ushort Sector { get; set; }

    }

}
