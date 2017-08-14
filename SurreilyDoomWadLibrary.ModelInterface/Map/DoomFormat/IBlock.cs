using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurreilyDoomWadLibrary.ElementInterface.Map.DoomFormat
{

    /// <summary>
    /// A Doom format blockmap block.
    /// </summary>
    public interface IBlock
    {

        /// <summary>
        /// The lines (or linedefs) within the block.
        /// </summary>
        IList<short> Lines { get; set; }

    }

}
