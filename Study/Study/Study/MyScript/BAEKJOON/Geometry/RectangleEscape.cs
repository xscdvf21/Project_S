using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.Geometry
{
    /// <summary>
    /// 직사각형에서 탈출
    /// 1085
    /// 직사각형과 점의 거리를 구하는 문제
    /// </summary>
    public class RectangleEscape
    {
        
        public void Function(int _x, int _y, int _w, int _h)
        {
            int minWitdh = MathF.Abs(_x - _w) < MathF.Abs(_x - 0) ? (int)MathF.Abs(_x - _w) : (int)MathF.Abs(_x - 0);
            int minHeight = MathF.Abs(_y - _h) < MathF.Abs(_y - 0) ? (int)MathF.Abs(_y - _h) : (int)MathF.Abs(_y - 0);

            int result = minWitdh < minHeight ? minWitdh : minHeight;

            Console.WriteLine(result);
        }

    }
}
