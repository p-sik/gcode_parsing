using System;
using System.Collections.Generic;
using System.Text;

namespace GCodeParser.Models
{
    /// <summary>
    /// Object containing all parsed and formatted data
    /// </summary>
    public class ParsedCode
    {
        //TODO [Serializable] in the future?
        public int NumberOfLines { get; set; }
        public List<float> LayerHeights { get; set; }
        public List<GCodeLine> ParsedLines { get; set; }
    }
}
