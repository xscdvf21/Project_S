using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.Math
{
    /// <summary>
    /// 세탁소 사장 동혁
    /// 2720
    /// </summary>
    public class CentConvert
    {
        public void Function(int[] _read)
        {
            int quarter = 25;
            int dime = 10;
            int nickel = 5;
            int penny = 1;

            string[] strs = new string[_read.Length];

            for(int i = 0; i < _read.Length; ++i)
            {
                int value = _read[i];

                strs[i] += (value / quarter).ToString() + " ";
                value -= quarter * (value / quarter);

                strs[i] += (value / dime).ToString() + " ";
                value -= dime * (value / dime);

                strs[i] += (value / nickel).ToString() + " ";
                value -= nickel * (value / nickel);

                strs[i] += (value / penny).ToString();
                value -= penny * (value / penny);

                Console.WriteLine(strs[i]);
            }

        }
    }
}
