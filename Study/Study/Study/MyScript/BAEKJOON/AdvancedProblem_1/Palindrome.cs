using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.AdvancedProblem_1
{
    /// <summary>
    /// 팰린드롬인지 확인하기
    /// 10988
    /// </summary>
    public class Palindrome
    {

        //true = 1;
        //false = 0;
        
        public void Function(string _str)
        {
            string str = "";
            for(int i = 0; i < _str.Length; ++i)
            {
                str += _str[(_str.Length - 1) + (-i)];
            }

            if (str == _str)
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }
    }
}
