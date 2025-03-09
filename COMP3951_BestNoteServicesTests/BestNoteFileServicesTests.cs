using System.Diagnostics;
using COMP3951_BestNoteServices;
using Microsoft.VisualBasic;

namespace COMP3951_BestNoteServicesTests
{
    [TestClass]
    public sealed class BestNoteFileServicesTests
    {
        public BestNoteFileManagerService bs = new BestNoteFileManagerService();

        /// <summary>
        /// Test for adding a folder to the file system.
        /// </summary>
        [TestMethod]
        public void TestRootDirectory()
        {
            // Get the root contents of the parent file
            DirectoryInfo output = bs.AppDirectory;
            Assert.IsNotNull(output);
            Debug.WriteLine($"Best note app data directory {output.FullName}");
        }

        /// <summary>
        /// Test for validatitng the root directory was created.
        /// </summary>
        [TestMethod]
        public void TestNoteDirectory()
        {
            // Get the root contents of the parent file
            TestRootDirectory();
            DirectoryInfo output = bs.BestNoteDirectory;
            Assert.IsNotNull(output);
            Debug.WriteLine($"Best note notes directory {output.FullName}");
        }

        /// <summary>
        /// Test for adding folders to the file system.
        /// </summary>
        [TestMethod]
        public void TestAddFolder()
        {
            TestNoteDirectory();
            DirectoryInfo output = bs.AddFolder("Will Testing Notes");
            Assert.IsNotNull(output);
            Debug.WriteLine($"Best note new folder directory {output.FullName}\nBest note new folder name {output.Name}");
        }

        /// <summary>
        /// Test for adding folders into other folders.
        /// </summary>
        [TestMethod]
        public void TestAddFolderToFolder()
        {
            TestNoteDirectory();
            DirectoryInfo output = bs.AddFolder("Will Testing Notes");
            Assert.IsNotNull(output);
            Debug.WriteLine($"Best note test parent {output.FullName}");
            DirectoryInfo output1 = bs.AddFolder("Will Testing Notes Sub", output.FullName);
            Assert.IsNotNull(output1);
            Debug.WriteLine($"Best note new folder directory {output1.FullName}\nBest note new folder name {output1.Name}");
        }

        /// <summary>
        /// Test for adding folders to the file system.
        /// </summary>
        [TestMethod]
        public void TestAddFile()
        {
            TestNoteDirectory();
            FileStream output = bs.AddFile("My notes");
            Assert.IsNotNull(output);
            Debug.WriteLine($"Best note new folder directory {output.Name}\nBest note new folder name {output.Name}");
        }

        /// <summary>
        /// Test for adding folders to the file system.
        /// </summary>
        [TestMethod]
        public void TestAddFileToFolder()
        {
            TestNoteDirectory();
            DirectoryInfo output = bs.AddFolder("Will Testing Notes");
            Assert.IsNotNull(output);
            Debug.WriteLine($"Best note test parent {output.FullName}");
            FileStream output1 = bs.AddFile("Will Testing Notes", parentPath: output.FullName);
            Assert.IsNotNull(output1);
            Debug.WriteLine($"Best note new folder directory {output1.Name}\nBest note new folder name {output1.Name}");
        }
    }
}
