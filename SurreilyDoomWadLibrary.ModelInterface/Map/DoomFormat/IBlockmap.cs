using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurreilyDoomWadLibrary.ElementInterface.Map.DoomFormat
{

    /// <summary>
    /// A Doom format blockmap.
    /// </summary>
    public interface IBlockmap
    {

        /// <summary>
        /// The grid's X origin.
        /// </summary>
        short X { get; set; }

        /// <summary>
        /// The grid's Y origin.
        /// </summary>
        short Y { get; set; }

        /// <summary>
        /// The number of columns in the grid.
        /// </summary>
        short Columns { get; set; }

        /// <summary>
        /// The number of rows in the grid.
        /// </summary>
        short Rows { get; set; }

        /// <summary>
        /// Gets the block at the specified location in the grid.
        /// </summary>
        /// <param name="x">The X position.</param>
        /// <param name="y">The Y position.</param>
        /// <returns>The block.</returns>
        IBlock GetBlock(int x, int y);

        /// <summary>
        /// Sets the block at the specified location in the grid.
        /// </summary>
        /// <param name="x">The X position.</param>
        /// <param name="y">The Y position.</param>
        /// <param name="block">The block.</param>
        void SetBlock(int x, int y, IBlock block);

        /// <summary>
        /// Enumerates over every block in the grid.
        /// </summary>
        /// <returns>A block enumerator.</returns>
        IEnumerator<IBlock> EnumerateBlocks();

    }

}
