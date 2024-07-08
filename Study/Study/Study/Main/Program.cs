using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Study.MyScript.BAEKJOON.Double_Array;
namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            //CroatiaAlphabet star = new CroatiaAlphabet();

            //string str = Console.ReadLine();
            //star.Function(str);


            //GroupMeanChecker checker = new GroupMeanChecker();

            //int count = Convert.ToInt32(Console.ReadLine());

            //string[] strs = new string[count];
            //for (int i = 0; i < strs.Length; ++i)
            //{
            //    strs[i] = Console.ReadLine();
            //}

            //checker.Function(strs);

            ///////////////////////////////////////
            //YourGrade yourGrade = new YourGrade();

            ////int count = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < 20; ++i)
            //{
            //    string read = Console.ReadLine();
            //    var strs = read.Split(" ");

            //    if (strs.Length > 3)
            //        continue;

            //    Grade grade = new Grade(strs[0], (float)Convert.ToDouble(strs[1]), strs[2]);
            //    yourGrade.AddGrades(grade);
            //}

            //yourGrade.Function();

            //////////////////////////////////////////
            //ProcessionSum processSum = new ProcessionSum();

            //string[] readStr = Console.ReadLine().Split(" ");

            //int col = Convert.ToInt32(readStr[0]);
            //int row = Convert.ToInt32(readStr[0]);

            //string[] strs = new string[col * 2];

            //for(int i = 0; i < col * 2; ++i)
            //{
            //    strs[i] = Console.ReadLine();
            //}

            //processSum.Function(row, col, strs);


            //int[,] values = new int[9, 9];
            //for(int i = 0; i < 9; ++i)
            //{
            //    string[] str = Console.ReadLine().Split(" ");

            //    for(int j = 0; j < str.Length; ++j)
            //    {
            //        values[i, j] = Convert.ToInt32(str[j]);
            //    }

            //}

            //MaxValueFind finds = new MaxValueFind();
            //finds.Function(values);

            ///////////////////////////////////////
            //HeightRead height = new HeightRead();

            //string[] readLines = new string[5];
            //for(int i = 0; i < 5; ++i)
            //{
            //    readLines[i] = Console.ReadLine();

            //}

            //height.Function(readLines);

            ///////////////////////////////////////
            ColoredPaper coloredPaper = new ColoredPaper();

            int count = Convert.ToInt32(Console.ReadLine());

            int[,] _pos = new int[count, 2];
            for(int i = 0; i < count; ++i)
            {
                string[] readLine = Console.ReadLine().Split(' ');
                for(int j = 0; j < readLine.Length; ++j)
                {
                    _pos[i, j] = Convert.ToInt32(readLine[j]);
                }
            }

            coloredPaper.Function(_pos);

        }
    }
}
