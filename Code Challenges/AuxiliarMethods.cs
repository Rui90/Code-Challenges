using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Code_Challenges
{
    public static class AuxiliarMethods
    {

        public static void Assert<T>(string exercise, int number, T result, string output)
        {
            if (result.ToString().Equals(output))
            {
                Console.WriteLine($"Exercise: {exercise} {number} passed");
            } else
            {
                Console.WriteLine($"Exercise: {exercise} {number} failed");
            }
        }

        public static List<string> ReadFiles(string exerciseName, bool input)
        {
            var files = new List<string>();
            var path = $"{Regex.Match(Directory.GetCurrentDirectory(), ".+?(?=bin)").Value}\\{exerciseName}\\files\\{GetFolder(input)}";
            foreach (string file in Directory.EnumerateFiles(path, "*.txt"))
            {
                files.Add(File.ReadAllText(file));
            }
            return files;
        }

        public static string GetFolder(bool input)
        {
            return input ? "input" : "output";
        }
    }
}
