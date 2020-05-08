using Code_Challenges;
using Code_Challenges.GradingStudents;
using Code_Challenges.IceCreamParlor;
using Code_Challenges.StrongPassword;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

public class Solution
{

    static void Main(string[] args)
    {

        Kangaroo kangaroo = new Kangaroo();
        kangaroo.Run();

        CamelCase camelCase = new CamelCase();
        camelCase.Run();

        StrongPassword strongPassword = new StrongPassword();
        strongPassword.Run();

        GradingStudents gradingStudents = new GradingStudents();
        gradingStudents.Run();

        IceCreamParlor iceCreamParlor = new IceCreamParlor();
        iceCreamParlor.Run();
    }
}
