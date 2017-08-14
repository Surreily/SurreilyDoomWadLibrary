using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurreilyDoomWadLibrary.ElementInterface.Map.DoomFormat
{

    /// <summary>
    /// A Doom format vertex.
    /// </summary>
    public interface IVertex
    {

        /// <summary>
        /// The vertex's X position.
        /// </summary>
        short X { get; set; }

        /// <summary>
        /// The vertex's Y position.
        /// </summary>
        short Y { get; set; }

    }

}
