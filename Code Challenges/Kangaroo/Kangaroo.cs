using System;

namespace Code_Challenges
{
    public class Kangaroo : IRun
    {
        public void Run()
        {
            var input = AuxiliarMethods.ReadFiles("Kangaroo", true);
            var output = AuxiliarMethods.ReadFiles("Kangaroo", false);
            for (int i = 0; i < input.Count; i++)
            {
                string[] split = input[i].Split(" ");
                int x1 = Convert.ToInt32(split[0]);
                int v1 = Convert.ToInt32(split[1]);
                int x2 = Convert.ToInt32(split[2]);
                int v2 = Convert.ToInt32(split[3]);
                AuxiliarMethods.Assert("Kangaroo", i, kangaroo(x1, v1, x2, v2), output[i]);
            }
        }

        private string kangaroo(int x1, int v1, int x2, int v2)
        {
            bool jumping = ValidateCondition(x1, v1, x2, v2);
            string result = "NO";
            while (jumping)
            {
                x1 = x1 + v1;
                x2 = x2 + v2;
                if (x1 == x2)
                {
                    result = "YES";
                    jumping = false;
                }
                jumping = ValidateCondition(x1, v1, x2, v2);
            };
            return result;
        }

        private bool ValidateCondition(int x1, int v1, int x2, int v2)
        {
            return !(x1 > x2 && v1 >= v2 || x1 < x2 && v2 >= v1);
        }
    }
}
