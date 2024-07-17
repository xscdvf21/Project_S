using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.Geometry
{
    /// <summary>
    /// 대지
    /// 9063
    /// 옥구슬을 모두 포함하는 직사각형을 찾는 문제
    /// </summary>
    public class RectangleGroundFind
    {
        public void Function(Queue<int[]> _queue)
        {
            int minX = int.MaxValue;
            int maxX = int.MinValue;
            int minY = int.MaxValue;
            int maxY = int.MinValue;

            if (_queue.Count < 2)
            {
                Console.WriteLine("0");
                return;
            }

            while(_queue.Count > 0)
            {
                int[] points = _queue.Dequeue();

                if (minX > points[0])
                    minX = points[0];

                if (maxX < points[0])
                    maxX = points[0];

                if (minY > points[1])
                    minY = points[1];
                                  
                if (maxY < points[1])
                    maxY = points[1];
            }

            Console.WriteLine((maxX - minX) * (maxY - minY));
        }
    }
}
