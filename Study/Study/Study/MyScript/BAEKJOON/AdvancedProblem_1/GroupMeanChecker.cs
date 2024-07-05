using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.AdvancedProblem_1
{
    /// <summary>
    /// 그룹 단어 체커
    /// 1316
    /// </summary>
    public class GroupMeanChecker
    {
        int count = 0;
        bool isCheck;
        public void Function(string[] _str)
        {
            for(int i = 0; i <_str.Length; ++i)
            {
                if (Checker(_str[i]))
                    count++;
            }

            Console.WriteLine(count);
        }


        public bool Checker(string str)
        {
            //1. 문자열 분리해서, 각각 인덱스 뽑아냄
            Dictionary<char, string > dic = new Dictionary<char, string >();

            for(int i = 0;  i < str.Length; ++i)
            {
                if (!dic.ContainsKey(str[i]))
                    dic.Add(str[i], i.ToString() + ",");
                else
                    dic[str[i]] = dic[str[i]] + i.ToString() + ","; 
            }

            foreach(var item in dic)
            {
                string[] temp = item.Value.Split(",");

                string[] strs = new string[temp.Length - 1];

                for(int i = 0; i < strs.Length; ++i)
                {
                    strs[i] = temp[i];
                }

                if (strs.Length < 2)
                    continue;

                for(int i = 0; i < strs.Length - 1; ++i)
                {
                    int value = Convert.ToInt32(str[i]) - Convert.ToInt32(str[i + 1]);
                    if (MathF.Abs(value) > 1)
                        return false;

                }
            }

            return true;

        }

    }
}
