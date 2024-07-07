using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.Double_Array
{
    /// <summary>
    /// 최댓값
    /// 2566
    /// </summary>
    public class MaxValueFind
    {

        public void Function(int[,] _values)
        {
            string str = "";
            int maxValue = int.MinValue;

            for(int i = 0; i < _values.GetLength(0); ++i)
            {
                for(int j = 0; j < _values.GetLength(1); ++j)
                {
                    if (_values[i, j] > maxValue)
                    {
                        maxValue = _values[i, j];
                        str = (i + 1).ToString() + " " + (j + 1).ToString();
                    }
                }
            }

            Console.WriteLine(maxValue);
            Console.WriteLine(str);
        }
    }
}
