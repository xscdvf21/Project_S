using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.CommonMultiple
{
    /// <summary>
    /// 배수와 약수
    /// 5086
    public class CommonMultipleFind
    {
        public void Function(Queue<int> _a, Queue<int> _b)
        {
            while(_a.Count > 0)
            {
                int a = _a.Dequeue();
                int b = _b.Dequeue();

                if (b % a == 0)
                    Console.WriteLine("factor");
                else if (a % b == 0)
                    Console.WriteLine("multiple");
                else
                    Console.WriteLine("neither");
            }
        }
    }
}
