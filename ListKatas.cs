using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWarsKatas
{
    class ListKatas
    {
        public static List<int> PipeFix(List<int> numbers)
        {
            List<int> result = new List<int>();
            int minValue = numbers.Min();
            int maxValue = numbers.Max();
            for(int i = minValue; i <= maxValue; i++)
            {
                result.Add(i);
            }
            return result;
        }
    }
}
