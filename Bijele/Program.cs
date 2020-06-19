using System;
using System.Collections.Generic;

namespace Bijele
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bijele 
            // https://open.kattis.com/problems/bijele


            var result = MissingPieces(EnterLine());
            PrintArrayOneLine(result);
        }

        private static void PrintArrayOneLine(int[] a)
        {
            var str = "";
            for (int i = 0; i < a.Length; i++)
            {
                str = str + a[i].ToString() + " ";
            }
            Console.WriteLine(str);
        }

        private static int[] MissingPieces(int[] a)
        {
            var res = new int[6] { 1 - a[0], 1 - a[1], 2 - a[2], 2 - a[3], 2 - a[4], 8 - a[5] };
            return res;
        }

        private static int[] EnterLine()
        {
            var arr = new string[6] { "", "","","","","" };
            var res = new int[6] { 0, 0, 0, 0, 0, 0 };
            try
            {
                arr = Console.ReadLine().Split(' ', 6);
                for (int i = 0; i < arr.Length; i++)
                {
                    res[i] = int.Parse(arr[i]);
                    if (res[i] < 0 || res[i] > 10)
                        throw new ArgumentException();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().ToString()+" || "+ex.Message);
                return EnterLine();
            }
            return res;
        }
    }
}
