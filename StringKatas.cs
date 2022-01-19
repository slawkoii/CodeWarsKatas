using System;
using System.Linq;

namespace CodeWarsKatas
{
    public class StringKatas
    {
        public static object[] IsVow(object[] a)
        {
            int[] vowelsCodesTabel = new int[5] { (int)'a', (int)'e', (int)'i', (int)'o', (int)'u' };

            for (int i = 0; i < a.Length; i++)
            {
                if (vowelsCodesTabel.Contains((int)a[i])) a[i] = Convert.ToChar(a[i]).ToString();
            }
            return a;
        }
        public static string MakeComplement(string dna) => dna.Replace('A', 't').Replace('C', 'g').Replace('T', 'a').Replace('G', 'c').ToUpper();

        public static string NameShuffler(string str)
        {
            string[] names = str.Split(" ");

            return names[1] + " " + names[0];   
        }

        public static bool Feast(string beast, string dish) => ((beast.Substring(0, 1) == dish.Substring(0, 1)) && (beast.Substring(beast.Length - 1, 1) == (dish.Substring(dish.Length - 1, 1))));

        public static string ReverseWords(string str) // toDo not working as expected !!!!
        {
            string[] worlds = str.Split(" ");
            string[] responses = new string[worlds.Length];
            for (int i = 0; i < worlds.Length; i++)
            {
                Array.Reverse(worlds[i].ToCharArray());
                responses[i] = new string(worlds[i]);
            }

            string response="";
            for(int i = 0; i < responses.Length; i++)
            {
                response += responses[i];
            }

            return response;
        }

    }
}
