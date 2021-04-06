using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarAlgo.Tue_6th_April
{
    class DuplicateCounter
    {
        // Solution 1
        public static int DuplicateCount(string str)
        {
            str = str.ToLower();
            List<object> myList = new List<object>();
            int i, j;
            for (i = 0; i < str.Length; i++)
            {
                for (j = i + 1;  j < str.Length; j++)
                {
                    if (str[j] == str[i] && !myList.Contains(str[j]))
                    {
                        myList.Add(str[j]);
                    }
                }
            }
            return myList.Count;
        }

        // Solution 2 Using LINQ
        public static int DuplicateCount2(string str)
        {
            return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
        }
    }
}
