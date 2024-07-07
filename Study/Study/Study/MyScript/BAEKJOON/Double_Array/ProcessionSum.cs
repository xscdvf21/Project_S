using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.Double_Array
{
    /// <summary>
    /// 행렬 덧셈
    /// 2738
    /// </summary>
    public class ProcessionSum
    {
        //가로 세로
        public void Function(int _row, int _col, string[] _strs)
        {
            int[,] values = new int[_col * 2, _row];

            for(int i = 0; i < _strs.Length; ++i)
            {
                string[] valueStr = _strs[i].Split(" ");
                for(int j = 0; j < valueStr.Length; ++j)
                {
                    values[i, j] = Convert.ToInt32(valueStr[j]);
                }
            }

            int[,] sumValue = new int[_col, _row];

            for (int i = 0; i < _col; ++i)
            {
                string outSrt = "";
                for (int j = 0; j < _row; ++j)
                {
                    sumValue[i, j] = values[i, j] + values[i + _col, j];
                    outSrt += sumValue[i, j].ToString() + " ";
                }
                Console.WriteLine(outSrt);
            }
        }
    }
}
