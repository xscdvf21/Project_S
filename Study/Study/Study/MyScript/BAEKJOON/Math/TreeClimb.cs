using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.Math
{
    /// <summary>
    /// 달팽이는 올라가고 싶다
    /// 2869
    /// </summary>
    public class TreeClimb
    {
        public void Function(int _a, int _b, int _v)
        {
            int sum = 0;
            int count = 1;
            while(true)
            {
                sum += _a;

                if (sum >= _v)
                    break;

                sum -= _b;
                count++;

            }
            Console.WriteLine(count);

        }
    }
}
