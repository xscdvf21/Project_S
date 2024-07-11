using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.Math
{
    /// <summary>
    /// 중앙이동 알고리즘
    /// 2903
    /// </summary>
    public class CenterMove
    {


        public void Function(int _value)
        {
            int x = 2;
            int y = 2;

            for(int i = 0; i < _value; ++i)
            {
                x = x * 2 - 1;
                y = y * 2 - 1;
            }
            int result = x * y;

            Console.WriteLine(result);
        }

    }
}
