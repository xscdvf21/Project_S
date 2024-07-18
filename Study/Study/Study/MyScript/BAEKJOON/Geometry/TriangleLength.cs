using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.Geometry
{
    /// <summary>
    /// 삼각형과 세 변
    /// 5073
    /// 변의 길이를 보고 삼각형을 판별하고 분류하는 문제
    /// </summary>
    public class TriangleLength
    {
        public void Function(Queue<int[]> _queue)
        {
            while (_queue.Count > 0)
            {
                int[] _data = _queue.Dequeue();

                int maxLength = int.MinValue;
                int sumLength = 0;

                for (int i = 0; i < _data.Length; ++i)
                {
                    if (maxLength < _data[i])
                        maxLength = _data[i];

                    sumLength += _data[i];
                }

                if (maxLength >= sumLength - maxLength)
                {
                    Console.WriteLine("Invalid");
                    continue;
                }

                if (_data[0] == _data[1] && _data[0] == _data[2] && _data[1] == _data[2])
                    Console.WriteLine("Equilateral");
                else if (_data[0] != _data[1] && _data[0] != _data[2] && _data[1] != _data[2])
                    Console.WriteLine("Scalene");
                else if (_data[0] == _data[1] || _data[0] == _data[2] || _data[1] == _data[2])
                    Console.WriteLine("Isosceles");
            }
        }
    }
}
