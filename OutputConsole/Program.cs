using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GCodeParser;

namespace OutputConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("G-code parser: Work in progress!");
            Console.WriteLine("--------------------------------");

            // string fileName = "sample_code.gcode";
            // string fullPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, fileName);
            // List<string> allLines = OutputUtilities.ReadFile(fullPath);

            // CodeParser parser = new CodeParser(allLines);

            Console.ReadKey();
        }
    }
}