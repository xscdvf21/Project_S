using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.CommonMultiple
{
    /// <summary>
    /// 소수 찾기_2
    /// 2581
    /// </summary>
    public class DecimalFind_2
    {
        public void Function(int _min, int _max)
        {
            int decimalSum = 0;
            int decimalMin = int.MaxValue;

            for(int i = _min; i <= _max; ++i)
            {
                int count = 0;
                for(int j = 1; j <= i; ++j)
                {
                    if (i % j == 0)
                        count++;

                   
                }

                if(count == 2)
                {
                    decimalSum += i;
                    if (decimalMin > i)
                        decimalMin = i;
                }
            }

            if(decimalSum == 0 && decimalMin == int.MaxValue)
            {
                Console.WriteLine("-1");
                return;
            }


            Console.WriteLine(decimalSum);
            Console.WriteLine(decimalMin);
        }
    }
}
