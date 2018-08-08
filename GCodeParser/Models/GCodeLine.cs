using System;
using System.Collections.Generic;
using System.Text;

namespace GCodeParser.Models
{
    /// <summary>
    /// Single line of formatted Gcode
    /// </summary>
    public class GCodeLine
    {
        public float XCoordinate { get; set; }
        public float YCoordinate { get; set; }
        public int Layer { get; set; }
    }
}
