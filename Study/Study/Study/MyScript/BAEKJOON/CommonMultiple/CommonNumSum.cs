using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 약수들의 합
/// 9506
/// </summary>
namespace Study.MyScript.BAEKJOON.CommonMultiple
{
    public class CommonNumSum
    {

        public void Function(Queue<int> _queue)
        {
            while(_queue.Count > 0)
            {
                Queue<int> temp = new Queue<int>();

                int num = _queue.Dequeue();
                int sum = 0;

                for(int i = 1; i < num; ++i)
                {
                    if (num % i == 0)
                    {
                        sum += i;
                        temp.Enqueue(i);
                    }
                }

                if(sum == num)
                {
                    Console.Write(sum + " = ");
                    while (temp.Count > 0)
                    {
                        int numTemp = temp.Dequeue();
                        Console.Write(numTemp);
                        if(temp.Count > 0)
                            Console.Write(" + ");
                    }

                }
                else
                {
                    Console.Write(num + " is NOT perfect.");
                }

                Console.WriteLine("");

            }    
        }
    }
}
