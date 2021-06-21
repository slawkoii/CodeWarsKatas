using System;
using System.Numerics;

namespace CodeWarsKatas
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] toShow = BaisicKatas.PowersOfTwo(3);
            for (int i = 0; i < toShow.Length; i++) 
            {
                Console.WriteLine(toShow[i]);
            }

           
        }
    }
}
