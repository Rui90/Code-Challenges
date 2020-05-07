using Code_Challenges;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

public class Solution
{

    static void Main(string[] args)
    {
        var path = Regex.Match(Directory.GetCurrentDirectory(), ".+?(?=bin)").Value;
        Kangaroo kangaroo = new Kangaroo();
        kangaroo.Run();

        CamelCase camelCase = new CamelCase();
        camelCase.Run(path.ToString());
    }
}
