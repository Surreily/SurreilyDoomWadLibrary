using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurreilyDoomWadLibrary.ElementInterface.Map.DoomFormat
{

    /// <summary>
    /// A Doom format map.
    /// </summary>
    public interface IMap : IElement
    {

        /// <summary>
        /// The map's name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The map's things.
        /// </summary>
        IList<IThing> Things { get; set; }

        /// <summary>
        /// The map's lines (or linedefs).
        /// </summary>
        IList<ILine> Lines { get; set; }

        /// <summary>
        /// The map's sides (or sidedefs).
        /// </summary>
        IList<ISide> Sides { get; set; }

        /// <summary>
        /// The map's vertexes.
        /// </summary>
        IList<IVertex> Vertexes { get; set; }

        /// <summary>
        /// The map's line segments (or segs).
        /// </summary>
        IList<ISegment> Segments { get; set; }

        /// <summary>
        /// The map's subsectors.
        /// </summary>
        IList<ISubsector> Subsectors { get; set; }

        /// <summary>
        /// The map's nodes.
        /// </summary>
        IList<INode> Nodes { get; set; }

        /// <summary>
        /// The map's sectors.
        /// </summary>
        IList<ISector> Sectors { get; set; }

        /// <summary>
        /// The map's reject table entries.
        /// TODO: replace string with appropriate class.
        /// </summary>
        IList<string> Reject { get; set; }

        /// <summary>
        /// The map's blockmap table entries.
        /// </summary>
        IBlockmap Blockmap { get; set; }

    }
}
