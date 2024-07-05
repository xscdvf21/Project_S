using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.AdvancedProblem_1
{
    /// <summary>
    /// 크로아티아 알파벳
    /// </summary>
    public class CroatiaAlphabet
    {
        string[] strs = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
        int count = 0;
        public void Function(string _str)
        {
            if (_str.Length > 100)
                return;

            count = 0;
            _str = _str.Trim();
            Recursion(_str);
            Console.WriteLine( (_str.Length - count) );
        }

        //재귀함수

        public void Recursion(string _src)
        {
            bool isCheck = false;

            for(int i = 0; i < strs.Length; ++i)
            {
                if(_src.Contains(strs[i]))
                {
                    int x = _src.IndexOf(strs[i]);
                    //제거하면 제거했을 때, 같은 문자열 생길 수 있으므로, 딴걸로 바꿔주고 새로검사
                    string strTemp = "";
                    for (int k = 0; k < strs[i].Length; ++k)
                    {
                        strTemp += "&";
                    }

                    _src = _src.Remove(x, strs[i].Length);
                    _src = _src.Insert(x, strTemp);
                    count += strs[i].Length - 1;
                    isCheck = true;
                    break;
                }
            }

            if (!isCheck)
                return;

            Recursion(_src);
        }
    }
}
