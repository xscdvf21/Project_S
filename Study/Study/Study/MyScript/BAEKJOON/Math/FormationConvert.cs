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
            int power = 0;
            for (int i = _str.Length - 1; i >= 0; i--)
            {
                char temp = _str[i];
                int value;
                if (Char.IsDigit(temp))
                {
                    value = temp - '0';
                }
                else
                    value = Char.ToUpper(temp) + 10 - 'A';

                sum += value * (int)MathF.Pow(_formationValue, power);
                power++;
            }

            Console.WriteLine(sum);
        }

    }
}
