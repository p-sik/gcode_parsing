using System;
using System.Collections.Generic;
using System.Linq;

namespace GCodeParser.Internal
{
    public class InstructionParameterExtractor
    {
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

            foreach (var value in parameterValues)
            {
                float numericValue = float.Parse(value.Substring(6));
                outputValues.Add(numericValue);
            }

            return outputValues;
        }

    }
}