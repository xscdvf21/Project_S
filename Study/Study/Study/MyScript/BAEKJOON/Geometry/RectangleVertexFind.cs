using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.Geometry
{
    /// <summary>
    /// 네 번째 점
    /// 3009
    /// 직사각형을 완성하는 문제
    /// </summary>
    public class RectangleVertexFind
    {

        public void Function(int[] _a, int[] _b, int[] _c)
        {
            int[] results = new int[2];

            results[0] = _a[0] == _b[0] ? _c[0] : (_b[0] == _c[0] ? _a[0] : _b[0]);
            results[1] = _a[1] == _b[1] ? _c[1] : (_b[1] == _c[1] ? _a[1] : _b[1]);

            Console.Write(results[0]);
            Console.Write(' ');
            Console.Write(results[1]);
        }
    }
}
