using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurreilyDoomWadLibrary.ElementInterface.Map.DoomFormat
{

    /// <summary>
    /// A Doom format sector.
    /// </summary>
    public interface ISector
    {

        /// <summary>
        /// The floor's height.
        /// </summary>
        short FloorHeight { get; set; }

        /// <summary>
        /// The ceiling's height.
        /// </summary>
        short CeilingHeight { get; set; }

        /// <summary>
        /// The floor's texture (or flat).
        /// </summary>
        string FloorTexture { get; set; }

        /// <summary>
        /// The ceiling's texture (or flat).
        /// </summary>
        string CeilingTexture { get; set; }

        /// <summary>
        /// The light level.
        /// </summary>
        short Light { get; set; }

        /// <summary>
        /// The sector action.
        /// </summary>
        short Action { get; set; }

        /// <summary>
        /// The tag.
        /// </summary>
        short Tag { get; set; }

    }

}
