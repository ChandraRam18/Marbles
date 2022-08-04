using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marbles
{
    public static class MarbleProcessor
    {
        public static List<Marble> SortAndFilter(List<Marble> inputMarbles)
        {
            List<Marble> returnMarbles = new List<Marble>();

            foreach (Marble marble in inputMarbles)
            {
                if (marble.Weight >= 0.5 && StringHelper.IsPalindrome(marble.Name) == true)                 //If the weight is more than or equal to 0.5 then add it to the list (Sorted And Filtered Marbles). Return marbles that has it's Palindrome as "true"
                    returnMarbles.Add(marble); 
            }

            returnMarbles = returnMarbles.OrderBy(marble => marble.Ordering).ToList();               //Return Marbles in the order I want it to (ROYGBIV).


            return returnMarbles;
        }
    }
}
