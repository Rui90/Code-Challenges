using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Code_Challenges.StrongPassword
{
    public class StrongPassword : IRun
    {

        public void Run()
        {
            var input = AuxiliarMethods.ReadFiles("StrongPassword", true);
            var output = AuxiliarMethods.ReadFiles("StrongPassword", false);
            for (int i = 0; i < input.Count; i++)
            {
                string[] split = input[i].Split( new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries); 
                AuxiliarMethods.Assert("StrongPassword", i, strongPassword(Convert.ToInt32(split[0]), split[1]), output[i].Replace("\n", string.Empty));
            }
        }
        private int strongPassword (int n, string password)
        {
            // Return the minimum number of characters to make the password strong
            int checkDigits = 6 - password.Length;
            int count = 0;
            if (!Regex.IsMatch(password, "[a-z]+")) count++;
            if (!Regex.IsMatch(password, "[A-Z]+")) count++;
            if (!Regex.IsMatch(password, "[\\d]+")) count++;
            if (!Regex.IsMatch(password, "[\\W]+")) count++;
            return checkDigits > count ?  checkDigits : count;
        }
    }
}
