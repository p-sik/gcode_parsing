using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GCodeParser;

namespace ParserOutputDisplay
{
    class Program
    {
        private const string testPath = @"C:\Users\Peter\Documents\CodeProjects\GCodeParsing\kalib_cil.gcode";

        static void Main(string[] args)
        {
            Console.WriteLine("G-code parser: Work in progress!");
            Console.WriteLine("--------------------------------");

            List<string> allLines = OutputUtilities.ReadFile(testPath);

            CodeParser parser = new CodeParser(allLines);

            Console.ReadKey();
        }
    }
}
