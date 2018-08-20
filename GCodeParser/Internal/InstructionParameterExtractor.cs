using System;
using System.Collections.Generic;
using System.Linq;

namespace GCodeParser.Internal
{
    public class InstructionParameterExtractor
    {
        //TODO process all the instructions in 1 method
        List<string> gcode;
        List<string> toolInstructions;
        public Dictionary<string, List<float>> ToolParameters;
        public InstructionParameterExtractor(List<string> gcode, List<string> instructions)
        {
            this.gcode = gcode;
            this.toolInstructions = instructions;
        }

        public List<float> ExtractParameterValues(string parameter)
        {
            List<string> parameterValues = new List<string>();
            List<float> outputValues = new List<float>();
            parameterValues = gcode.Where(x => x.Contains(parameter)).ToList();

            if (parameterValues.Count == 0)
            {
                throw new FormatException("No matches in gcode");
            }

            foreach (var value in parameterValues)
            {
                string numberFromString = value.Substring(6);
                float numericValue;
                bool isParseSuccessful = float.TryParse(numberFromString, out numericValue);
                if (!isParseSuccessful)
                {
                    throw new ArgumentException("Parameter parsing unsuccesfull.");
                }
                outputValues.Add(numericValue);
            }

            return outputValues;
        }

    }
}