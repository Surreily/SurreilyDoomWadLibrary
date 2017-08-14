using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurreilyDoomWadLibrary.ElementInterface
{

    /// <summary>
    /// Enum defining possible WAD types.
    /// </summary>
    public enum WadType
    {
        Iwad,
        Pwad
    }

    /// <summary>
    /// Represents a WAD file.
    /// </summary>
    public interface IWad
    {

        /// <summary>
        /// The wad's type.
        /// </summary>
        WadType Type { get; set; }

        /// <summary>
        /// The wad's file size in bytes.
        /// </summary>
        int Size { get; }

        IList<IElement> Elements { get; set; }

    }

}
