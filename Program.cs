using System;

namespace CodeWarsKatas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] toShow = ArrayKatas.AddLength("apple ban");
            for (int i = 0; i < toShow.Length; i++) 
            {
                Console.WriteLine(toShow[i]);
            }
        }
    }
}
