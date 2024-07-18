using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.TimeComplextiy
{
    /// <summary>
    /// 알고리즘 수업 - 알고리즘의 수행 시간 3
    /// 24264
    /// ...실행 횟수가 "대략적으로" 얼마나 빨리 커지는지는 비교적 간단하게 알 수 있습니다. 이 문제들에서 출력의 두 번째 줄이 바로 그것입니다.
    /// </summary>
    public class Algorithm_3
    {
        /// <summary>
        /// O(n 제곱)
        /// 500000, 까지 받아, uint 도 넘어감.
        /// </summary>
        /// <param name="_n"></param>
        public void Function(long _n)
        {
            Console.WriteLine(_n * _n);
            //(_n)제곱 이므로, 이차 항수 ex) 7a * 7a = 7a2;
            Console.WriteLine("2");

        }
    }
}
