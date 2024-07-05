using System;
using Study.MyScript.BAEKJOON.AdvancedProblem_1;
using System.Collections.Generic;
namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            //CroatiaAlphabet star = new CroatiaAlphabet();

            //string str = Console.ReadLine();
            //star.Function(str);


            GroupMeanChecker checker = new GroupMeanChecker();

            int count = Convert.ToInt32(Console.ReadLine());

            string[] strs = new string[count];
            for (int i = 0; i < strs.Length; ++i)
            {
                strs[i] = Console.ReadLine();
            }

            checker.Function(strs);
        }
    }
}
