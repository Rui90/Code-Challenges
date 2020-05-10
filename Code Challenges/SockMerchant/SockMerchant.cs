using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Challenges.SockMerchant
{
    public class SockMerchant : IRun
    {
        public void Run()
        {
            var input = AuxiliarMethods.ReadFiles("SockMerchant", true);
            var output = AuxiliarMethods.ReadFiles("SockMerchant", false);
            for(int i = 0; i < input.Count; i++)
            {
                string[] split = input[i].Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                var result = SockerMerchant(Array.ConvertAll(split[1].Split(' '), arrTemp => Convert.ToInt32(arrTemp)));
                AuxiliarMethods.Assert("SockMerchant", i, result, output[i]); ;
            }

        }

        private int SockerMerchant(int[] arr)
        {
            List<int> paired = new List<int>();
            for(int i = 0; i < arr.Length; i++)
            {
                if (!paired.Contains(i) && i < arr.Length-1)
                {
                    var result = SockComparator(i, arr);
                    if (result != -1) paired.Add(result);
                }
            }
            return paired.Count;
        }

        private int SockComparator(int currentPosition, int[] arr)
        {
            for (int j = currentPosition + 1; j < arr.Length; j++)
            {
                if (arr[currentPosition] == arr[j])
                {
                    return j;
                }
            }
            return -1;
        }
    }
}
