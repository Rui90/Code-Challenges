using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Challenges.GradingStudents
{
    public class GradingStudents : IRun
    {
        public void Run()
        {
            var input = AuxiliarMethods.ReadFiles("GradingStudents", true);
            var output = AuxiliarMethods.ReadFiles("GradingStudents", false);
            for (int i = 0; i < input.Count; i++)
            {
                string[] split = input[i].Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                var list = new List<int>();
                for (int j = 1; j < split.Length; j++)
                {
                    list.Add(Convert.ToInt32(split[j]));
                }
                AuxiliarMethods.Assert("GradingStudes", i, string.Join("\n", gradingStudents(list)), output[i]);
            }
        }

        private List<int> gradingStudents(List<int> grades)
        {
            List<int> gradesFinalList = new List<int>();
            grades.ForEach((grade) => {
                int nextMultiple = grade + (5 - grade % 5);
                if (grade < 38)
                {
                    gradesFinalList.Add(grade);
                }
                else if (grade == nextMultiple)
                {
                    gradesFinalList.Add(grade);
                }
                else if (nextMultiple - grade < 3)
                {
                    gradesFinalList.Add(nextMultiple);
                }
                else
                {
                    gradesFinalList.Add(grade);
                }
            });
            return gradesFinalList;
        }
    }
}
