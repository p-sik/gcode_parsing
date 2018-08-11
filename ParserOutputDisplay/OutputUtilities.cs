using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserOutputDisplay
{
    public class OutputUtilities
    {
        public static List<string> ReadFile(string path)
        {
            var allLines = new List<string>(10_000);
            using (StreamReader reader = File.OpenText(path))
            {
                string s = "";
                while ((s = reader.ReadLine()) != null)
                {
                    allLines.Add(s);
                }
            }
            return allLines;
        }
    }
}
