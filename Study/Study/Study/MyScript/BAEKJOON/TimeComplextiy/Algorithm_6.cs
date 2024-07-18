using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.TimeComplextiy
{
    /// <summary>
    /// 알고리즘 수업 - 알고리즘의 수행 시간 6
    /// 24267
    /// 그 역할을 하는 것이 바로 시간 복잡도입니다.
    /// </summary>
    public class Algorithm_6
    {
        public void Function(ulong _n)
        {
            // (_n - 1) * _n / 2 + 
            // (_n - 2) * (_n - 1) / 2
            Console.WriteLine( ((_n - 1) * _n / 2) + ((_n - 2) * (_n - 1) / 2) - 1 );
            Console.WriteLine("3");

            int count = 0;
            for(ulong i = 0; i < _n; ++i)
            {
                for(ulong j = i + 1; j < _n; ++j)
                {
                    for(ulong k = j + i; k < _n; ++k)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
