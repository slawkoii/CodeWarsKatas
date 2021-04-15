﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWarsKatas
{
    class BaisicKatas
    {
        public static string SwitchItUp(int number)
        {
            Dictionary<int, string> numbers = new Dictionary<int, string>
            {
                {1,"One"}, {2,"Two"}, {3,"Three"}, {4, "Four"}, {5,"Five"}, {6,"Six"}, {7,"Seven"}, {8,"Eight"}, {9,"Nine"}, {0,"Zero"},
            };
            if (numbers.TryGetValue(number, out string result)) return result;
            else return "Not correct number entered";
        }

        public static int GetRealFloor(int n)
        {
            if (n > 12) return n - 2;
            if (n > 0) return n - 1;
            return n;
        }

        public static int ReverseNumber(int n)
        {
            int result = 0;
            while (n > 0)
            {
                result = result * 10 + n % 10;
                n /= 10;
            }

            return result;
        }
    }
}
