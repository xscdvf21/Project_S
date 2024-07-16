using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.Double_Array
{
    /// <summary>
    /// 세로 읽기
    /// 2738
    /// </summary>
    public class HeightRead
    {
        string ouputStr = "";
        float maxStr = float.MinValue;
        public void Function(string[] _readLine)
        {
            for(int i = 0; i < _readLine.Length; ++i)
            {
                if (maxStr < _readLine[i].Length)
                    maxStr = _readLine[i].Length;
            }
            
            Recursion(_readLine, 0, 0 );

            Console.WriteLine(ouputStr);
        }

        public void Recursion(string[] _readLine, int _iIndex, int _start)
        {
            if (_start > maxStr)
                return;

            for(int i = 0; i < _readLine.Length; ++i)
            {
                if (_readLine[i].Length - 1 < _iIndex)
                    continue;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
                ouputStr += _readLine[i][_iIndex];
            }

            Recursion(_readLine, _iIndex + 1, _start + 1);
         }
    }
}
