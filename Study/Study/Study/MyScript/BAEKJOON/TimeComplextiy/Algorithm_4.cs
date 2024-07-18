using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.TimeComplextiy
{
    /// <summary>
    /// 알고리즘 수업 - 알고리즘의 수행 시간 4
    /// 24265
    /// n이 커질수록 n과 n²의 차이는 어마어마하게 벌어지기 때문에,
    /// </summary>
    class Algorithm_4
    {
        //    _n! 팩토리얼 ? 
        //    MenOfPassion(A[], n) {
        //      sum <- 0;
        //      for i <- 1 to n - 1
        //          for j <- i + 1 to n
        //              sum <- sum + A[i] × A[j]; # 코드1
        //      return sum;
        //    }
        //    (_n - 1) * n / 2

        public void Function(ulong _n)
        {
            Console.WriteLine((_n - 1) * _n / 2);
            Console.WriteLine("2");
            
        }

    }
}
