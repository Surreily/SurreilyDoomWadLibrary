using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurreilyDoomWadLibrary.ElementInterface.Map.DoomFormat
{

    /// <summary>
    /// A Doom format node.
    /// </summary>
    public interface INode
    {

        /// <summary>
        /// The partition line's starting X position.
        /// </summary>
        short PartitionStartX { get; set; }

        /// <summary>
        /// The partition line's starting Y position.
        /// </summary>
        short PartitionStartY { get; set; }

        /// <summary>
        /// The partition line's relative ending X position.
        /// </summary>
        short PartitionOffsetX { get; set; }

        /// <summary>
        /// The partition line's relative ending Y position.
        /// </summary>
        short PartitionOffsetY { get; set; }

        /// <summary>
        /// The right bounding box.
        /// </summary>
        INodeBoundingBox RightBoundingBox { get; set; }

        /// <summary>
        /// The left bounding box.
        /// </summary>
        INodeBoundingBox LeftBoundingBox { get; set; }

        /// <summary>
        /// The right child node.
        /// </summary>
        short RightChild { get; set; }

        /// <summary>
        /// The left child node.
        /// </summary>
        short LeftChild { get; set; }

    }

}
