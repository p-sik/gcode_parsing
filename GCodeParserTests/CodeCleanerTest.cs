using System;
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
            string path = @"C:\Users\Peter\Documents\CodeProjects\GCodeParsing\kalib_cil.gcode";
            var allLines = OutputUtilities.ReadFile(path);
            var cleanLines = CodeCleaner.CleanUpCode(allLines);

            string expectedFirstLine = "G0 F10500 X57.967 Y78.308 Z0.300";
            Assert.AreEqual(expectedFirstLine, cleanLines[2]);
        }

        [TestMethod]
        public void CleansEndOfFile()
        {
            string path = @"C:\Users\Peter\Documents\CodeProjects\GCodeParsing\kalib_cil.gcode";
            var allLines = OutputUtilities.ReadFile(path);
            var cleanLines = CodeCleaner.CleanUpCode(allLines);

            string expectedLastLine = "M84                            ; steppers off";
            Assert.AreEqual(expectedLastLine, cleanLines.Last());
        }
    }
}
