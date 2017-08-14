using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SurreilyDoomWadLibrary.File;
using SurreilyDoomWadLibrary.Wad;
using SurreilyDoomWadLibrary.Wad.DoomFormatMap;
using System.Collections.Generic;
using SurreilyDoomWadLibrary.File.ElementLoader;

namespace SurreilyDoomWadLibrary.Test.ElementLoader
{

    [TestClass]
    [DeploymentItem(@"TestData\testmap.wad", "TestData")]
    public class DoomFormatMapElementLoaderTest
    {

        [TestMethod]
        public void The_Loader_Detects_A_Map()
        {

            IList<DirectoryEntry> entries = new List<DirectoryEntry>();

            entries.Add(new DirectoryEntry(0, 0, "MAP01"));
            entries.Add(new DirectoryEntry(0, 1000, "THINGS"));
            entries.Add(new DirectoryEntry(0, 1000, "LINEDEFS"));
            entries.Add(new DirectoryEntry(0, 1000, "SIDEDEFS"));
            entries.Add(new DirectoryEntry(0, 1000, "VERTEXES"));
            entries.Add(new DirectoryEntry(0, 1000, "SEGS"));
            entries.Add(new DirectoryEntry(0, 1000, "SSECTORS"));
            entries.Add(new DirectoryEntry(0, 1000, "NODES"));
            entries.Add(new DirectoryEntry(0, 1000, "SECTORS"));
            entries.Add(new DirectoryEntry(0, 1000, "REJECT"));
            entries.Add(new DirectoryEntry(0, 1000, "BLOCKMAP"));

            Assert.AreEqual(11, new DoomFormatMapElementLoader().CanLoad(null, entries));

        }

        [TestMethod]
        public void The_Loader_Accepts_A_Map_With_Minimal_Data()
        {

            IList<DirectoryEntry> entries = new List<DirectoryEntry>();

            entries.Add(new DirectoryEntry(0, 0, "MAP01"));
            entries.Add(new DirectoryEntry(0, 1000, "THINGS"));
            entries.Add(new DirectoryEntry(0, 1000, "LINEDEFS"));
            entries.Add(new DirectoryEntry(0, 1000, "SIDEDEFS"));
            entries.Add(new DirectoryEntry(0, 1000, "VERTEXES"));
            entries.Add(new DirectoryEntry(0, 1000, "SECTORS"));

            Assert.AreEqual(6, new DoomFormatMapElementLoader().CanLoad(null, entries));

        }

        [TestMethod]
        public void The_Loader_Rejects_A_Map_Missing_Important_Data()
        {

            IList<DirectoryEntry> entries = new List<DirectoryEntry>();

            entries.Add(new DirectoryEntry(0, 0, "MAP01"));
            entries.Add(new DirectoryEntry(0, 1000, "THINGS"));
            entries.Add(new DirectoryEntry(0, 1000, "SIDEDEFS"));
            entries.Add(new DirectoryEntry(0, 1000, "VERTEXES"));
            entries.Add(new DirectoryEntry(0, 1000, "SEGS"));
            entries.Add(new DirectoryEntry(0, 1000, "SSECTORS"));
            entries.Add(new DirectoryEntry(0, 1000, "NODES"));
            entries.Add(new DirectoryEntry(0, 1000, "SECTORS"));
            entries.Add(new DirectoryEntry(0, 1000, "REJECT"));
            entries.Add(new DirectoryEntry(0, 1000, "BLOCKMAP"));

            Assert.AreEqual(0, new DoomFormatMapElementLoader().CanLoad(null, entries));

        }

        [TestMethod]
        public void The_Loader_Rejects_A_Map_With_A_Non_Blank_Header_Entry()
        {

            IList<DirectoryEntry> entries = new List<DirectoryEntry>();

            entries.Add(new DirectoryEntry(0, 1000, "MAP01"));
            entries.Add(new DirectoryEntry(0, 1000, "THINGS"));
            entries.Add(new DirectoryEntry(0, 1000, "LINEDEFS"));
            entries.Add(new DirectoryEntry(0, 1000, "SIDEDEFS"));
            entries.Add(new DirectoryEntry(0, 1000, "VERTEXES"));
            entries.Add(new DirectoryEntry(0, 1000, "SEGS"));
            entries.Add(new DirectoryEntry(0, 1000, "SSECTORS"));
            entries.Add(new DirectoryEntry(0, 1000, "NODES"));
            entries.Add(new DirectoryEntry(0, 1000, "SECTORS"));
            entries.Add(new DirectoryEntry(0, 1000, "REJECT"));
            entries.Add(new DirectoryEntry(0, 1000, "BLOCKMAP"));

            Assert.AreEqual(0, new DoomFormatMapElementLoader().CanLoad(null, entries));

        }

        [TestMethod]
        public void The_Wad_Has_A_Map()
        {

            WadLoader loader = new WadLoader();
            WadFile wad = loader.Load(@"TestData\testmap.wad");

            Assert.AreEqual(1, wad.Elements.Count);
            Assert.AreEqual(typeof(DoomFormatMapElement), wad.Elements[0].Type);

        }
        
        [TestMethod]
        public void A_Wad_Has_The_Correct_Number_Of_Things()
        {

            WadLoader loader = new WadLoader();
            WadFile wad = loader.Load(@"TestData\testmap.wad");
            DoomFormatMapElement map = (DoomFormatMapElement) wad.Elements[0];

            Assert.AreEqual(28, map.Things.Count);

        }

        [TestMethod]
        public void A_Wad_Has_The_Correct_Number_Of_Lines()
        {

            WadLoader loader = new WadLoader();
            WadFile wad = loader.Load(@"TestData\testmap.wad");
            DoomFormatMapElement map = (DoomFormatMapElement)wad.Elements[0];

            Assert.AreEqual(74, map.Lines.Count);

        }

        [TestMethod]
        public void A_Wad_Has_The_Correct_Number_Of_Sides()
        {

            WadLoader loader = new WadLoader();
            WadFile wad = loader.Load(@"TestData\testmap.wad");
            DoomFormatMapElement map = (DoomFormatMapElement)wad.Elements[0];

            Assert.AreEqual(100, map.Sides.Count);

        }

        [TestMethod]
        public void A_Wad_Has_The_Correct_Number_Of_Vertexes()
        {

            WadLoader loader = new WadLoader();
            WadFile wad = loader.Load(@"TestData\testmap.wad");
            DoomFormatMapElement map = (DoomFormatMapElement)wad.Elements[0];

            Assert.AreEqual(69, map.Vertexes.Count);

        }

        [TestMethod]
        public void A_Wad_Has_The_Correct_Number_Of_Sectors()
        {

            WadLoader loader = new WadLoader();
            WadFile wad = loader.Load(@"TestData\testmap.wad");
            DoomFormatMapElement map = (DoomFormatMapElement)wad.Elements[0];

            Assert.AreEqual(17, map.Sectors.Count);

        }

    }

}
