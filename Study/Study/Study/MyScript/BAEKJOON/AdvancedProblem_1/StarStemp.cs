using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.AdvancedProblem_1
{
    /// <summary>
    /// 별 찍기 - 7
    /// 2444
    /// </summary>
    class StarStemp
    {

        public void Function(string _star)
        {
            int input = Convert.ToInt32(_star);
            int star = (input * 2) - 1;


            int airCount = input;
            for(int i = 0; i < star; ++i)
            {
                string str = "";
                int minIndex = star - airCount;
                int maxIndex = star - minIndex;
                for(int j =0; j < star; ++j)
                {
                    if (j < minIndex)
                        str += " ";
                    else if (j >= maxIndex)
                        continue;
                    else
                        str += "*";
                }

                Console.WriteLine(str);

                if (i >= input - 1)
                    airCount--;
                else
                    airCount++;

                
            }

        }
    }
}
