using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marbles
{
    public static class StringHelper
    {
        public static bool IsPalindrome(String input)
        {
            String lowerCaseTest = input.ToLower();
            char[] chars = lowerCaseTest.ToCharArray();
            StringBuilder sb = new StringBuilder();

            foreach (char c in chars)
            {
                if (char.IsLetter(c))
                    sb.Append(c);
            }

            string cleanAndLowercaseString = sb.ToString();
            char[] cleanChars = cleanAndLowercaseString.ToCharArray();
            Array.Reverse(cleanChars);
            string reverse = new string(cleanChars);

            if (reverse == cleanAndLowercaseString)
            {
                return true;            }

            else
            {
                return false;  
            }

        }
    }
}
