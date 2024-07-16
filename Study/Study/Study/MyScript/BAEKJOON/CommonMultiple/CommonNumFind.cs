using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 약수 구하기
/// 2501
/// </summary>
namespace Study.MyScript.BAEKJOON.CommonMultiple
{
    public class CommonNumFind
    {
        public void Function(int _number, int _n)
        {
            List<int> list = new List<int>();

            for(int i = 1; i <= _number; ++i)
            {
                if (_number % i == 0)
                    list.Add(i);
            }

            if (list.Count - 1 < _n - 1)
            {
                Console.WriteLine(0);
                return;
            }
            Console.WriteLine(list[_n - 1]);
        }
    }
}
