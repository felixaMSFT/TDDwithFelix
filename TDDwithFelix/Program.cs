using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDwithFelix
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }

        public static int AtoI(string number)
        {
            if (String.IsNullOrWhiteSpace(number))
                return 0;

            number = number.Trim();

            int total = 0;

            for (int index = 0; index < number.Length; index++)
            {
                int value = number[index];

                value = value - '0';

                total = (total * 10) + value;
            }

            return total;
        }
    }
}