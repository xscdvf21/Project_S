using System;
using System.Collections.Generic;
using System.Text;

namespace Study.MyScript.BAEKJOON.AdvancedProblem_1
{
    /// <summary>
    /// 킹, 퀸, 룩, 비숍, 나이트, 폰 
    /// 3003
    /// </summary>
    public class ChessPiece
    {
        private int[] chessPiece = { 1, 1, 2, 2, 2, 8 };

        public void Function(string _piece)
        {
            string[] inputs = _piece.Split(" ");

            int[] values = new int[inputs.Length];
            for(int i = 0; i < inputs.Length; ++i)
            {
                values[i] = Convert.ToInt32(inputs[i]);
                values[i] = chessPiece[i] - values[i];
                Console.Write(values[i] + " ");
            }                          
        }
    }
}
