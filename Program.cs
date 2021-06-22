using System;
using System.Numerics;

namespace CodeWarsKatas
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new object[] { 'a', 'b', 'c', 'd', 'e' };
            object[] toShow = ArrayKatas.TakeFirstElements(arr,-1);
            for (int i = 0; i < toShow.Length; i++) 
            {
                Console.WriteLine(toShow[i]);
            }

           
        }
    }
}
