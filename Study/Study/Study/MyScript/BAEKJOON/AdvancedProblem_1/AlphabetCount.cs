using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Study.MyScript.BAEKJOON.AdvancedProblem_1
{
    /// <summary>
    /// 단어 공부
    /// 1157
    /// </summary>
    public class AlphabetCount
    {
        public void Function(string _str)
        {
            if (_str.Length > 1000000)
                return;

            Dictionary<char, int> dic = new Dictionary<char, int>();

            for(int i = 0; i < _str.Length; ++i)
            {
                if (!dic.ContainsKey(char.ToUpper(_str[i])))
                    dic.Add(char.ToUpper(_str[i]), 1);
                else
                {
                    if (dic.TryGetValue(char.ToUpper(_str[i]), out int result))
                        dic[char.ToUpper(_str[i])] = result + 1;
                }                
            }


            
            int maxValue = dic.Max(x => x.Value);
            KeyValuePair<char, int> pairResult = new KeyValuePair<char, int>();
            int maxCount = 0;

            foreach(var item in dic)
            {
 
                if(maxValue == item.Value)
                {
                    pairResult = item;
                    maxCount++;
                }    

            }
            if (maxCount > 1)
                Console.WriteLine("?");
            else
                Console.WriteLine(pairResult.Key);
        }
    }
}
