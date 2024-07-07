using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Study.MyScript.BAEKJOON.AdvancedProblem_1
{
    /// <summary>
    /// 너의 평점은
    /// 25206
    /// </summary>
    public class YourGrade
    {

        List<Grade> grades = new List<Grade>();
        public void Function()
        {
            Console.WriteLine(grades.Sum(x => x.Average()) / grades.Sum(x => x.gradeScore));
        }

        public void AddGrades(Grade _grade)
        {
            if (_grade.grade == "P")
                return;

            grades.Add(_grade);
        }

    }

    public class Grade
    {

        public string className;
        public float gradeScore;
        public string grade;

        public Grade(string _name, float _score, string _grade)
        {
            className = _name;
            gradeScore = _score;
            grade = _grade;
        }

        public float Average()
        {
            float score = float.MinValue;
            if (grade == "A+")
            {
                score = gradeScore * 4.5f;
            }
            else if (grade == "A0")
            {
                score = gradeScore * 4.0f;
            }
            else if (grade == "B+")
            {
                score = gradeScore * 3.5f;
            }
            else if (grade == "B0")
            {
                score = gradeScore * 3.0f;
            }
            else if (grade == "C+")
            {
                score = gradeScore * 2.5f;
            }
            else if (grade == "C0")
            {
                score = gradeScore * 2.0f;
            }
            else if (grade == "D+")
            {
                score = gradeScore * 1.5f;
            }
            else if (grade == "D0")
            {
                score = gradeScore * 1.0f;
            }
            else if (grade == "F")
            {
                score = gradeScore * 0f;
            }
            return score;
        }
    }


}
