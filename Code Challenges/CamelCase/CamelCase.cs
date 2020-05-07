using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Code_Challenges
{
    public class CamelCase
    {
        public void Run(string path)
        {
            var input = AuxiliarMethods.ReadFiles("CamelCase", true);
            var output = AuxiliarMethods.ReadFiles("CamelCase", false);
            for (int i = 0; i < input.Count; i++)
            {
                AuxiliarMethods.Assert("CamelCase", i, NumberOfWords(input[i]), output[i]);
            }
        }

        private string NumberOfWords(string input)
        {
            return Regex.Matches(input, "([a-z])+|([A-Z][a-z]+)").Count.ToString();
        }
    }
}
