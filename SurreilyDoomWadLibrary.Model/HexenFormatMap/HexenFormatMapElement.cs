﻿using SurreilyDoomWadLibrary.Wad.DoomFormatMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurreilyDoomWadLibrary.Wad.HexenFormatMap
{

    /// <summary>
    /// A hexen format map.
    /// </summary>
    public class HexenFormatMapElement : NamedElement
    {

        /// <summary>
        /// Constructor for a Hexen format map.
        /// </summary>
        /// <param name="name"></param>
        public HexenFormatMapElement(string name) : base(name)
        {
        }

        /// <summary>
        /// The map's things.
        /// </summary>
        public IList<HexenFormatMapElementThing> Things { get; set; }

        /// <summary>
        /// The map's lines.
        /// </summary>
        public IList<HexenFormatMapElementLine> Lines { get; set; }

        /// <summary>
        /// The map's sides. Doom format sides are used, as there is no
        /// difference for Hexen format.
        /// </summary>
        public IList<DoomFormatMapElementSide> Sides { get; set; }

        /// <summary>
        /// The map's vertexes. Doom format vertexes are used, as there is no
        /// difference for Hexen format.
        /// </summary>
        public IList<DoomFormatMapElementVertex> Vertexes { get; set; }

        /// <summary>
        /// The map's segments.
        /// </summary>
        public byte[] Segments { get; set; }

        /// <summary>
        /// The map's subsectors.
        /// </summary>
        public byte[] SubSectors { get; set; }

        /// <summary>
        /// The map's nodes.
        /// </summary>
        public byte[] Nodes { get; set; }

        /// <summary>
        /// The map's sectors. Doom format sectors are used, as there is no
        /// difference for Hexen format.
        /// </summary>
        public IList<DoomFormatMapElementSector> Sectors { get; set; }

        /// <summary>
        /// The map's reject table.
        /// </summary>
        public byte[] RejectTable { get; set; }

        /// <summary>
        /// The map's blockmap.
        /// </summary>
        public byte[] Blockmap { get; set; }

        #region IElement implementation

        public override Type Type { get { return typeof(HexenFormatMapElement); } }

        #endregion

    }
}
