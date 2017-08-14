using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurreilyDoomWadLibrary.ElementInterface.Map.DoomFormat
{

    /// <summary>
    /// A Doom format side (or sidedef).
    /// </summary>
    public interface ISide
    {

        /// <summary>
        /// The side's (or sidedef's) X offset for textures.
        /// </summary>
        short XOffset { get; set; }

        /// <summary>
        /// The side's (or sidedef's) Y offset for textures.
        /// </summary>
        short YOffset { get; set; }

        /// <summary>
        /// The side's (or sidedef's) upper texture.
        /// </summary>
        string UpperTexture { get; set; }

        /// <summary>
        /// The side's (or sidedef's) lower texture.
        /// </summary>
        string LowerTexture { get; set; }

        /// <summary>
        /// The side's (or sidedef's) middle texture.
        /// </summary>
        string MiddleTexture { get; set; }

        /// <summary>
        /// The side's (or sidedef's) sector.
        /// </summary>
        short Sector { get; set; }

    }

}
