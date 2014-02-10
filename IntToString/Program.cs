using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntToString
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 256;

            Console.WriteLine("String representation of {0} is {1}", num, IntToString(num));

            string str = "-23";

            Console.WriteLine("Int representation of {0} is {1}", str, StringToInt(str));
        }

        static string IntToString(int num)
        {
            if (num == 0)
            {
                return "0";
            }

            bool IsNegative = false;

            if (num < 0)
            {
                IsNegative = true;
                num *= -1;
            }

            StringBuilder result = new StringBuilder("");

            while (num > 0)
            {
                char digit = (char)((num % 10) + '0');

                result.Append(digit);

                num /= 10;
            }

            if (IsNegative)
            {
                result.Append("-");
            }

            char[] reversedNumber = result.ToString().ToArray();

            Array.Reverse(reversedNumber);

            String number = new String(reversedNumber);

            return number;
        }

        // 230
        // 2 -> result * 10 + char -> 2
        // 3 -> 20 + 3 -> 23
        // 0 -> 230 + 0

        // -23

        static int StringToInt(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new Exception("Invalid input");
            }

            bool IsNegative = false;

            int startIndex = 0;

            if (str.StartsWith("-"))
            {
                IsNegative = true;
                startIndex = 1;
            }

            int result = 0;

            while (startIndex < str.Length)
            {
                int digit = str[startIndex] - '0';
                result = (result * 10) + digit;
                startIndex++;
            }

            if (IsNegative)
            {
                result *= -1;
            }

            return result;
        }
    }
}
