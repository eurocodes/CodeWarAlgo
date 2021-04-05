using System;
using CodeWarAlgo.Mon_5th_April;

namespace CodeWarAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreatePhone.CreatePhonenum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));

            Console.WriteLine(SortIntergerInDesc.DescendingOrder(124521067));
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
