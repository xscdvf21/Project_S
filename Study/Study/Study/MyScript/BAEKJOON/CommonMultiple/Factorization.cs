using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.CommonMultiple
{
    /// <summary>
    /// 소인수분해
    /// 11653
    /// </summary>
    public class Factorization
    {
        public void Function(int _number)
        {
            if (_number == 1)
                return;

            Queue<int> queue = new Queue<int>();
            int number = _number;
            while(true)
            {
                bool isDecimal = false;
                for(int i = 2; i <= _number; ++i)
                {
                    if(number % i == 0)
                    {
                        if (i == number)
                            isDecimal = true;

                        number = number / i;
                        queue.Enqueue(i);
                        break;
                    }
                }

                if (isDecimal)
                    break;
            }

            while(queue.Count > 0)
            {
                int write = queue.Dequeue();
                Console.WriteLine(write);
            }
        }
    }
}
