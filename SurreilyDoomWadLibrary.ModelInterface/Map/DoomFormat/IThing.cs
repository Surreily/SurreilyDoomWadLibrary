using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurreilyDoomWadLibrary.ElementInterface.Map.DoomFormat
{

    /// <summary>
    /// A Doom format thing.
    /// </summary>
    public interface IThing
    {

        /// <summary>
        /// The thing's X position.
        /// </summary>
        short X { get; set; }

        /// <summary>
        /// The thing's Y position.
        /// </summary>
        short Y { get; set; }

        /// <summary>
        /// The thing's angle.
        /// </summary>
        short Angle { get; set; }

        /// <summary>
        /// The thing's type.
        /// </summary>
        short Type { get; set; }

        /// <summary>
        /// The thing's flags.
        /// </summary>
        short Flags { get; set; }

    }

}
