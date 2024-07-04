using System;
using Study.MyScript.BAEKJOON.AdvancedProblem_1;
using System.Collections.Generic;
namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            CroatiaAlphabet star = new CroatiaAlphabet();

            string str = Console.ReadLine();
            star.Function(str);
        }
    }
}
