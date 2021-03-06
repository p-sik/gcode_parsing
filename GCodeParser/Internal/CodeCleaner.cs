﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GCodeParser.Models;

namespace GCodeParser.Internal
{
    public class CodeCleaner
    {
        public static List<string> CleanUpCode(List<string> originalCode)
        {
            List<string> cleanGCode = new List<string>(originalCode.Count);
            var filters = ParsingFilter.Filter.ToList<string>();

            cleanGCode = originalCode.Where(line =>
                line.IndexOf(";") != 0 &&
                !string.IsNullOrWhiteSpace(line) &&
                !(line.Contains("G1") && line.Contains("F"))
                ).ToList();

            List<string> maskList = new List<string>();

            foreach (var filter in filters)
            {
                cleanGCode = cleanGCode.Where(x => !x.Contains(filter)).ToList();
            }
            return cleanGCode;
        }
    }
}
