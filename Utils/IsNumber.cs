using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker.Utils
{
    public static class IsNumber
    {
        public static bool IsNumberOrNot(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false; 
            }

            foreach (char c in input)
            {
                if (c < '0' || c > '9')
                {
                    return false; 
                }
            }
            return true;
        }
    }
}
