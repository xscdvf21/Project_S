using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.Geometry
{
    /// <summary>
    /// 삼각형 외우기
    /// 10101
    /// 각도를 보고 삼각형을 판별하고 분류하는 문제
    /// </summary>
    public class Triangle
    {
        public void Function(int _a, int _b, int _c)
        {

            if (_a + _b + _c != 180)
                Console.WriteLine("Error");
            else if (_a == 60 && _b == 60 && _c == 60)
                Console.WriteLine("Equilateral");
            else if (_a == _b || _a == _c || _b == _c)
                Console.WriteLine("Isosceles");
            else
                Console.WriteLine("Scalene");


        }
    }
}
