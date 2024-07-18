using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.TimeComplextiy
{
    /// <summary>
    /// 알고리즘 수업 - 알고리즘의 수행 시간 5
    /// 24266
    /// "대략적으로"만 파악해도 자신의 코드가 시간 초과가 날 지 아닐지를 어느 정도 예측할 수 있습니다.
    /// </summary>
    public class Algorithm_5
    {
        /// <summary>
        /// O(n) 3제곱
        /// </summary>
        public void Function(ulong _n)
        {
            Console.WriteLine((_n * _n * _n));
            
            Console.WriteLine("3");
        }
    }
}
