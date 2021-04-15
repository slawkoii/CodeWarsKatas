using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWarsKatas
{
    public class ArrayKatas
    {
        public static int Min(int[] list) => list.Min();
        public static int Max(int[] list) => list.Max();

        public static void ShowAnArray(object[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
            }
        }

        public static bool SmallEnough(int[] a, int limit)
        {
            bool answer = true;
            for(int i = 0; i <= a.Length; i++)
            {
                if (a[i] > limit) answer = false;
            }
            return answer;
        }

    }
}
