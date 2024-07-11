using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.Math
{
    /// <summary>
    /// 진법 변환 2
    /// 11005번
    /// </summary>
    public class ReverseFormationConvert
    {
        //1. 10진법 수를 특정 N 수로 나타내기

        public void Function(int _value, int _formationValue)
        {
            int value = _value;
            int formationValue = _formationValue;


            Stack<int> stack = new Stack<int>();

            while(value > 0)
            {
                stack.Push(value % formationValue);
                value = value / formationValue;
            }


            string result ="";

            while(stack.Count > 0)
            {
                int output = stack.Pop();

                if (output >= 10)
                {
                    char ch = (char)('A' + (output - 10));
                    result += ch;
                }
                else
                    result += output.ToString();

            }

            Console.WriteLine(result);
        }
    }
}
