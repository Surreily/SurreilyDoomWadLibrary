using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurreilyDoomWadLibrary.ElementInterface.Map
{

    /// <summary>
    /// A node's bounding box.
    /// </summary>
    public interface INodeBoundingBox
    {

        /// <summary>
        /// The top boundary.
        /// </summary>
        int Top { get; set; }

        /// <summary>
        /// The bottom boundary.
        /// </summary>
        int Bottom { get; set; }

        /// <summary>
        /// The left boundary.
        /// </summary>
        int Left { get; set; }

        /// <summary>
        /// The right boundary.
        /// </summary>
        int Right { get; set; }

    }

}
