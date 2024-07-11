using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.Math
{
    /// <summary>
    /// 벌집
    /// 2292
    /// </summary>
    public class HoneyComb
    {
        public void Function(int _value)
        {
            int comb = 1;
            int mulValue = 6;
            int honeyCount = 0;
            while(true)
            {
                comb += mulValue * honeyCount;
                honeyCount++;
                if (comb >= _value)
                    break;

            }

            Console.WriteLine(honeyCount);
        }
    }
}
