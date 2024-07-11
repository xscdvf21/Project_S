using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.Math
{
    /// <summary>
    /// 분수찾기
    /// 1193
    /// </summary>
    public class FountainFind
    {
        public void Function(int _value)
        {
            Recursion(_value, 1, 1, 1, 1, 0);
        }

        /// <summary>
        /// 재귀 함수, 초기 시작값이 분모 분자 1에서 시작하므로,
        /// </summary>
        /// <param name="_iIndex"></param>
        /// <param name="_count"></param>
        /// <param name="_loopCount"></param>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        /// <param name="_lineCount"></param>
        void Recursion(int _iIndex, int _count, int _loopCount, int _x, int _y, int _lineCount)
        {

            var loop = _lineCount % 2;

            int x = _x;
            int y = _y;
            for (int i = 0; i < _loopCount; ++i)
            {
                if (_iIndex == _count)
                {

                    Console.WriteLine(y + "/" + x);
                    return;
                }

                _count++;


                //아래에서 위로
                if (loop == 0)
                {
                    x++;
                    y--;
                }
                //위에서 아래로
                else
                {
                    x--;
                    y++;
                }

            }

            //재귀 함수 돌때는, 분모 분자 시작 인덱스가 중요
            if(loop == 0)
                Recursion(_iIndex, _count, _loopCount + 1, _x + _loopCount, 1, _lineCount + 1);
            else
                Recursion(_iIndex, _count, _loopCount + 1, 1, _y + _loopCount , _lineCount + 1);
        }

    }
}
