using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace GCodeParser
{
    public class CodeParser
    {
        List<string> lines;

        public CodeParser(List<string> codeLines)
        {
            lines = codeLines;            
        }          
    }
}
