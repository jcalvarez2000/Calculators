using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    public class Calculator
    {
        public enum Format
        {
            Decimal,
            Hexadecimal,
            Octal,
            Binary
        }

        static private string SumCalculate(int shortestLength, int longestLength, string shortestValue, string longestValue, Format theFormat = Format.Decimal)
        {
            StringBuilder result = new StringBuilder();

            int j = shortestLength;
            int valueCarried = 0;
            int sum;
            for (int i = longestLength - 1; i >= 0; --i)
            {
                if (j > 0)
                { 
                    sum = longestValue[i] - '0' + shortestValue[j - 1] - '0' + valueCarried;
                    valueCarried = 0;
                    if (sum >= 10)
                    { 
                        valueCarried = 1;
                        result.Insert(0, sum - 10);
                    }
                    else
                        result.Insert(0, sum);

                }
                else
                {
                    
                    result.Insert(0, longestValue[i] - '0' + valueCarried);
                    valueCarried = 0;
                }

                --j;
            }

            if (valueCarried > 0)
                result.Insert(0, 1);

            return result.ToString();
        }
        static public string Add(string value1, string value2, Format theFormat = Format.Decimal)
        {
            if (theFormat != Format.Decimal)
                throw new NotImplementedException("Format not implemented yet.");

            int length1 = value1.Length;
            int length2 = value2.Length;

            if (length1 >= length2)
                return SumCalculate(length2, length1, value2, value1);
            return SumCalculate(length1, length2, value1, value2);
        }
    }
}
