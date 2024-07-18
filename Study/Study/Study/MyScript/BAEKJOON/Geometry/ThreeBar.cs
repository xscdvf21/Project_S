using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Study.MyScript.BAEKJOON.Geometry
{
    /// <summary>
    /// 세 막대
    /// 14215
    /// 가능한 한 둘레가 긴 삼각형을 만드는 문제
    /// </summary>
    public class ThreeBar
    {
        public void Function(List<int> _list)
        {
            int maxIndex = _list.IndexOf(_list.Max());
            int sum = 0;
            for(int i = 0; i < _list.Count; ++i)
            {
                if (i == maxIndex)
                    continue;

                sum += _list[i];
            }
            if (_list[maxIndex] >= sum)
                sum += (sum - 1);
            else
                sum += _list[maxIndex];

            Console.WriteLine(sum);
        }


    }
}
