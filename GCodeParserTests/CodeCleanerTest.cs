using System;
using System.IO;
using System.Linq;
using GCodeParser.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutputConsole;

namespace GCodeParserTest
{
    [TestClass]
    public class CodeCleanerTest
    {
        [TestMethod]
        public void CleansStartOfFile()
        {
            string fileName = "sample_code.gcode";
            string fullPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, fileName);
            var allLines = OutputUtilities.ReadFile(fullPath);
            var cleanLines = CodeCleaner.CleanUpCode(allLines);

            string expectedFirstLine = "G0 F10500 X57.967 Y78.308 Z0.300";
            Assert.AreEqual(expectedFirstLine, cleanLines[2]);
        }

        [TestMethod]
        public void CleansEndOfFile()
        {
            string fileName = "sample_code.gcode";
            string fullPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, fileName);
            var allLines = OutputUtilities.ReadFile(fullPath);
            var cleanLines = CodeCleaner.CleanUpCode(allLines);

            string expectedLastLine = "M84                            ; steppers off";
            Assert.AreEqual(expectedLastLine, cleanLines.Last());
        }
    }
}
