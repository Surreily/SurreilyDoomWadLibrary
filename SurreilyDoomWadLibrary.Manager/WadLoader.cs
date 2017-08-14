using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SurreilyDoomWadLibrary.File.ElementLoader;
using SurreilyDoomWadLibrary.Wad;

namespace SurreilyDoomWadLibrary.File
{

    public class WadLoader
    {

        protected IList<ElementLoader.BaseElementLoader> _loaders { get; set; }

        public WadLoader()
        {

            // Initialize the list of element loaders.
            _loaders = new List<ElementLoader.BaseElementLoader>();

            // Add some default element loaders.
            _loaders.Add(new DoomFormatMapElementLoader());
            _loaders.Add(new UnknownElementLoader());

        }

        public WadFile Load(string path)
        {

            using (BinaryReader reader = new BinaryReader(new FileStream(path, FileMode.Open)))
            {

                // Read the WAD header.
                Byte[] wadType = reader.ReadBytes(4);
                Int32 directoryLength = reader.ReadInt32();
                Int32 directoryOffset = reader.ReadInt32();

                // Prepare the WAD.
                WadFile wad;

                // Construct the WAD object based on the type. The first
                // character (P or I) determines the type.
                switch (wadType[0])
                {

                    case (byte)'P':
                        wad = new WadFile(WadType.Pwad);
                        break;

                    case (byte)'I':
                        wad = new WadFile(WadType.Iwad);
                        break;

                    default:
                        throw new Exception("Invalid WAD type.");

                }

                // Set the reader position to the directory.
                reader.BaseStream.Position = directoryOffset;

                // Read the entire directory.
                IList<DirectoryEntry> directory = new List<DirectoryEntry>();
                for (int index = 0; index < directoryLength; index++)
                {

                    directory.Add(new DirectoryEntry(
                        reader.ReadInt32(),
                        reader.ReadInt32(),
                        new string(reader.ReadChars(8)).Trim('\0')
                    ));

                }

                // Read the remainder of the WAD file by using element loaders.
                while (directory.Count > 0)
                {
                    foreach (BaseElementLoader loader in _loaders)
                    {

                        // Get the number of entries to consume.
                        int consume = loader.CanLoad(reader, directory);

                        // If the loader can load some entries, allow it to do
                        // so.
                        if (consume > 0)
                        {

                            // Load the element.
                            wad.Elements.Add(loader.Load(reader, directory.Take(consume).ToList()));

                            // Remove the consumed elements from the list, then
                            // break out of the foreach.
                            directory = directory.Skip(consume).ToList();
                            break;

                        }

                    }

                }

                // Return the WAD.
                return wad;

            }

        }

    }

}
