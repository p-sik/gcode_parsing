using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GCodeParser.Models;

namespace GCodeParser.Internal
{
    public class CodeCleaner
    {
        //TODO test and finish the clean-up
        public static List<string> CleanUpCode(List<string> originalCode)
        {
            List<string> cleanGCode = new List<string>(originalCode.Count);
            var filters = ParsingFilter.Filter.ToList<string>();

            cleanGCode = originalCode.Where(line =>
                line.IndexOf(";") != 0 &&
                !string.IsNullOrWhiteSpace(line) &&
                !(line.Contains("G1") && !line.Contains("X") && !line.Contains("Y") && !line.Contains("Z"))
                ).ToList();

            return cleanGCode;
        }
    }
}
