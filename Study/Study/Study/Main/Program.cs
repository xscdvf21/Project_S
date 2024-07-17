//using Study.MyScript.BAEKJOON.Math;
using Study.MyScript.BAEKJOON.Geometry;
using System;
using System.Collections.Generic;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleLength find = new TriangleLength();

            Queue<int[]> queue = new Queue<int[]>();
            while (true)
            {
                string[] readStr = Console.ReadLine().Split(' ');
                int[] lengths = new int[3];

                lengths[0] = int.Parse(readStr[0]);
                lengths[1] = int.Parse(readStr[1]);
                lengths[2] = int.Parse(readStr[2]);
                if (lengths[0] == 0 && lengths[1] == 0 && lengths[2] == 0)
                    break;

                queue.Enqueue(lengths);
         
            }

            find.Function(queue);

        }
    }
}
  