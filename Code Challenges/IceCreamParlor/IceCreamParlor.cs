using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code_Challenges.IceCreamParlor
{
    public class IceCreamParlor : IRun
    {
        public void Run()
        {
            var input = AuxiliarMethods.ReadFiles("IceCreamParlor", true);
            var output = AuxiliarMethods.ReadFiles("IceCreamParlor", false);
            for (int i = 0; i < input.Count; i++)
            {
                string[] split = input[i].Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                int numberOfTrips = Convert.ToInt32(split[0]);
                var result = new List<string>();
                int readingPosition = 1;
                for(int j = 0; j < numberOfTrips; j++)
                {
                    var tmpResult = iceCreamParlor(Convert.ToInt32(split[readingPosition]), Array.ConvertAll(split[readingPosition+2].Split(' '), arrTemp => Convert.ToInt32(arrTemp)));
                    result.Add(string.Join(" ", tmpResult.Select(p => p.ToString()).ToArray()));
                    readingPosition += 3;
                }
                AuxiliarMethods.Assert("IceCreamParlor", i, string.Join("\n", result), output[i]);
            }
        }

        private int[] iceCreamParlor(int m, int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (m == arr[i] + arr[j])
                    {
                        return new int[] { i+1, j+1 };
                    }
                }
            }
            return null;
        }
    }
}
