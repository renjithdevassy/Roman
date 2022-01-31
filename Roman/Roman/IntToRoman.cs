using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman
{
    public class IntToRoman
    {
        public string RomanConvertion(int number)
        {
            String[] roman = new String[] { "I", "V", "X", "L", "C", "D", "M"};
            int[] decimals = new int[] { 1, 5, 10, 50, 100, 500, 1000 };
            string romanvalue = String.Empty;
            for (int i = 0; i < 7; i++)
            {
                while (number >= decimals[i])
                {
                    number = number - decimals[i];
                    romanvalue = romanvalue + roman[i];
                }
            }
            return romanvalue;
        }

    }
}
