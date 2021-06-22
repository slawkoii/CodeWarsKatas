using System;
using System.Numerics;

namespace CodeWarsKatas
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new object[] {  };
            object[] toShow = ArrayKatas.TakeFirstElements(arr,2);
            for (int i = 0; i < toShow.Length; i++) 
            {
                Console.WriteLine(toShow[i]);
            }

           
        }
    }
}
