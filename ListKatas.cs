using System.Collections.Generic;
using System.Linq;

namespace CodeWarsKatas
{
    public class ListKatas
    {
        public static List<int> PipeFix(List<int> numbers)
        {
            List<int> result = new List<int>();
            int minValue = numbers.Min();
            int maxValue = numbers.Max();
            for (int i = minValue; i <= maxValue; i++)
            {
                result.Add(i);
            }
            return result;
        }

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
          List<int> result = new List<int>();
 
          foreach(object v in listOfItems)
          {
              if (v is int)

               result.Add((int)v);
          }
            return result;
        }


    }
}
