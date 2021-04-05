using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarAlgo.Mon_5th_April
{
    class CreatePhone
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            string phone = "(";
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < 2)
                {
                    phone += numbers[i];
                }
                else if (i == 2)
                {
                    phone += numbers[i] + ") ";
                }
                else if (i> 2 && i < 5)
                {
                    phone += numbers[i];
                }
                else if (i == 5)
                {
                    phone += numbers[i] + "-";
                }
                else
                {
                    phone += numbers[i];
                }
            }
            return phone;
        }

        public static string CreatePhonenum(int[] number)
        {
            return $"({number[0]}{number[1]}{number[2]}) " +
                $"{number[3]}{number[4]}{number[5]}-{number[6]}{number[7]}{number[8]}{number[9]}";
        }
    }
}
