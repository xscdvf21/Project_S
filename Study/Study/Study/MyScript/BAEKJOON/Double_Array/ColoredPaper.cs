using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.Double_Array
{
    /// <summary>
    /// 색종이
    /// 2563
    /// </summary>
    public class ColoredPaper
    {
        //가로 세로 색종이 시작 위치
        public void Function(int[,] _pos)
        {

            //**************************************************************//
            //몬테칼로 적분법. 어떤 함수의 특정 구간에서의 넓이를 구하고 싶다면,
            //일정한 개수의 점을 균일하게 분포시켜서 해당 함수 이내에 점이 몇개 찍혀있는지를 파악하여 근사적으로 넓이를 구하는 방법.

            int[,] area = new int[100, 100];


           
            for(int x = 0; x < _pos.GetLength(0); ++x)
            {
                int witdh = _pos[x, 0];
                int height = _pos[x, 1];

                for (int i = 0; i < 10; ++i)
                {
                    for (int j = 0; j < 10; ++j)
                    {
                        area[witdh + i, height + j] = 1;
                    }
                }
            }

            int count = 0;

            for(int i = 0; i < area.GetLength(0); ++i)
            {
                for (int j = 0; j < area.GetLength(1); ++j)
                {
                    if (area[i, j] == 1)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
