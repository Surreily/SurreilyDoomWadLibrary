using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurreilyDoomWadLibrary.ElementInterface
{

    public enum ElementType
    {
        DoomFormatMap,
        HexenFormatMap,
        UdmfFormatMap,
        Textures,
        Flats
    }

    public interface IElement
    {

        ElementType Type { get; }

    }

}
