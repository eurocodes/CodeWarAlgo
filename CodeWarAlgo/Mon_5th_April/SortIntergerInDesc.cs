using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarAlgo.Mon_5th_April
{
    class SortIntergerInDesc
    {
        public static int DescendingOrder(int num)
        {
            // Bust a move right here
            int number;
            string newNum = num.ToString();
            string[] numStrArr = new string[newNum.Length];
            for (int i = 0; i < newNum.Length; i++)
            {
                numStrArr[i] = newNum[i].ToString();
            }
            Array.Sort(numStrArr);
            Array.Reverse(numStrArr);
            string str = string.Join("", numStrArr);
            number = Int32.Parse(str);
            return number;
        }
    }
}
