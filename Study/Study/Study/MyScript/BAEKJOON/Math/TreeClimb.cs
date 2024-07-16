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
            // 2 1 5 = 4;
            // 100 99 1000000000000000 = 999999999999901
            // 6 1 5 = 2

            int day = 0;
            if ((_v - _b) % (_a - _b) == 0)
            {
                day = (_v - _b) / (_a - _b);
            }
            else
                day = (_v - _b) / (_a - _b) + 1;


            //int sum = 0;
            //int count = 1;
            //while(true)
            //{
            //    sum += _a;

            //    if (sum >= _v)
            //        break;

            //    sum -= _b;
            //    count++;

            //}
            Console.WriteLine(day);

        }
    }
}
