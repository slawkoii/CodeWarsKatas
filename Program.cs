using System;

namespace CodeWarsKatas
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] a = { 101, 121, 110, 113, 113, 103, 121, 121, 101, 107, 103 };
            int[] b = { 7, 8, 8, 9, 11 };
            int[] vowelsCodesTabel = new int[5] { (int)'a', (int)'e', (int)'i', (int)'o', (int)'u' };
            //ArrayKatas.ShowAnArray(StringKatas.IsVow(a));
            Console.WriteLine(BaisicKatas.ReverseNumber(123));
        }
    }
}
