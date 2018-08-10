using System;
using System.Collections.Generic;
using System.Text;

namespace GCodeParser.Models
{
    public class ParsingFilter
    {
        static string[] defaultFilter = {
            "G28", // endstop movement
            "G92", // extruder position set/reset
            "G90", // absolute positioning command
            "\n", // empty lines
            ";" // only comment lines
        };

        private string[] filter;

        public string[] Filter
        {
            get => filter ?? defaultFilter;
            set => filter = value;
        }

        public ParsingFilter(params string[] filteredCommands)
        {
            filter = new string[filteredCommands.Length];
        }
    }
}
