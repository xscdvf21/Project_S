using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.Math
{
    /// <summary>
    /// 진법 변환
    /// 2745
    /// </summary>
    public class FormationConvert
    {
        //1. 진번 변환 자리수 마다 끊어서 봄.
        //(35 * 진법(제곱 자리수) 1의 자리까지 해서 다더해줌 )
        //...10진법으로 표현하는것.. 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_value">진법</param>
        /// <param name="_str">밸류 값</param>
        /// 'A' = 65
        public void Function(string _str, int _formationValue)
        {

            int sum = 0;
            for (int i = 0; i < _str.Length; ++i)
            {
                int temp = _str[_str.Length - (i + 1)];

                if (temp >= '0' && temp <= '9')
                {
                    temp = temp - '0';
                }
                else
                    temp = temp + 10 - 'A';


                sum += temp * (int)(MathF.Pow(_formationValue, i));
            }

            Console.WriteLine(sum);
        }
    }
}
