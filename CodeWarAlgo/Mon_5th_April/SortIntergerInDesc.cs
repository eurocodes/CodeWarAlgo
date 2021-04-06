using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarAlgo.Mon_5th_April
{
    class SortIntergerInDesc
    {
        // Solution 1
        public static int DescendingOrder(int num)
        {
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
        // Solutions 2 Using Linq
        public static int DescendingOrder2(int num)
        {
            return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
        }

        // Solution 3
        public static int DescendingOrder3(int num)
        {
            char[] arr = num.ToString().ToCharArray();
            Array.Sort(arr);
            Array.Reverse(arr);
            return Convert.ToInt32(new string(arr));
        }
    }
}
