﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurreilyDoomWadLibrary.Wad
{

    /// <summary>
    /// Define the two WAD types.
    /// </summary>
    public enum WadType
    {
        Iwad,
        Pwad
    }

    /// <summary>
    /// A WAD file.
    /// </summary>
    public class WadFile
    {

        /// <summary>
        /// Constructor for a WAD.
        /// </summary>
        /// <param name="type">The type of WAD.</param>
        public WadFile(WadType type)
        {
            Type = type;
            Elements = new List<IElement>();
        }

        /// <summary>
        /// The type.
        /// </summary>
        public WadType Type { get; set; }

        /// <summary>
        /// The size in bytes.
        /// </summary>
        public int Size
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// The elements.
        /// </summary>
        public IList<IElement> Elements { get; set; }

    }

}
