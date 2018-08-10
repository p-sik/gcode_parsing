using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace GCodeParser.Models
{
    public static class ParsingFilter
    {
        static string[] defaultFilter = {
            "G28", // endstop movement
            "G92", // extruder position set/reset
            "G90", // absolute positioning command
            "G21", // metric values
            "M82",
            "M203",
            "M117",
            "M107",
            "\n", // empty lines
        };

        private static string[] filter;

        public static string[] Filter
        {
            get
            {
                if (filter == null)
                {
                    return defaultFilter;
                }
                else if (filter.All(x => string.IsNullOrWhiteSpace(x)))
                {
                    return defaultFilter;
                }
                else
                {
                    return filter;
                }
            }
            set => filter = value;
        }
    }
}
