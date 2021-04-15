using System;
using System.Linq;

namespace CodeWarsKatas
{
    public class StringKatas
    {
        public static object[] IsVow(object[] a)
        {
            int[] vowelsCodesTabel = new int[5] {(int)'a',(int)'e',(int)'i',(int)'o', (int)'u'};
            
            for(int i = 0; i < a.Length; i++)
            {
                if (vowelsCodesTabel.Contains((int)a[i])) a[i] = Convert.ToChar(a[i]).ToString();
            }
            return a;
        }
    }
}
