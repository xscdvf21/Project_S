using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.CommonMultiple
{
    /// <summary>
    /// 소수 찾기
    /// 1978
    /// </summary>
    public class DecimalFind
    {

        public void Function(int[] _numbers)
        {
            int count = 0;
            for(int i = 0; i < _numbers.Length; ++i)
            {
                int decimalCount = 0;
                for(int j = 1; j <= _numbers[i]; ++j)
                {
                    if (_numbers[i] % j == 0)
                        decimalCount++;
                }

                if (decimalCount == 2)
                    count++;
            }

            Console.WriteLine(count);
        }


    }
}
