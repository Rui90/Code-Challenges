using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Challenges.RepeatedStrings
{
    public class RepeatedStrings : IRun
    {
        public void Run()
        {
            var input = AuxiliarMethods.ReadFiles("RepeatedStrings", true);
            var output = AuxiliarMethods.ReadFiles("RepeatedStrings", false);
            for (int i = 0; i < input.Count; i++)
            {
                string[] split = input[i].Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                AuxiliarMethods.Assert("RepeatedStrings", i, NumberOfRepeatedAs(split[0], Convert.ToInt64(split[1])), output[i]);
            }
        }
        
        public long NumberOfRepeatedAs(string s, long n)
        {
            int numberOfAs = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString().Equals("a"))
                {
                    numberOfAs++;
                }
            }

            if (numberOfAs == s.Length) return n;
            var rest = n % s.Length;
            long counter = n / s.Length * numberOfAs;
            if (rest == 0)
            {
                return counter;
            }
            for (int i = 0; i < rest; i++)
            {
                if (s[i].ToString().Equals("a"))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
