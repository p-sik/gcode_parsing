using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GCodeParser.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutputConsole;

namespace GCodeParserTest
{
    [TestClass]
    public class InstructionExtractorTest
    {
        [TestMethod]
        public void ExtractsValuesForInstruction(){

            string fileName = "sample_code.gcode";
            string fullPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, fileName);
            var allLines = OutputUtilities.ReadFile(fullPath);
            var cleanLines = CodeCleaner.CleanUpCode(allLines);

            InstructionParameterExtractor extractor = new InstructionParameterExtractor(cleanLines, null);
            var actual = extractor.ExtractParameterValues("M190");
            List<float> expected = new List<float>();
            expected.Add(60f);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}