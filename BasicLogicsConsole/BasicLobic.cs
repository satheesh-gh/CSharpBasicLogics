using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicsConsole
{
    internal class BasicLobic
    {
        public string PolinNumber(int number)
        {
            int reverse = 0;
            int originalNumber = number;
            while (number > 0)
            {
                int digit = number % 10;
                reverse = (reverse * 10) + digit;
                number /= 10;
            }
            if (originalNumber == reverse)
            {
                return $"{originalNumber} is a palindrome number.";
            }
            else
            {
                return $"{originalNumber} is not a palindrome number.";
            }
        }
        public string PolinString(string text)
        {
            string reverse = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverse += text[i];
            }
            if (text == reverse)
            {
                return $"{text} is a palindrome string.";
            }
            else
            {
                return $"{text} is not a palindrome string.";
            }
        }

        public string IsPrime(int number)
        {
            for (int i = 2; i <= number / i; i++)
            {
                if (number % i == 0)
                    return "Not Prime";
            }
            return "Prime";
        }

        public string Fibonacci(int n)
        {
            int a = 0, b = 1, c;
            StringBuilder sb = new StringBuilder();
            sb.Append(a + " " + b + " ");
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                sb.Append(c + " ");
                a = b;
                b = c;
            }
            return sb.ToString();
        }

        public string SwapNumbers(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            return $"After swapping: a = {a}, b = {b}";
        }
    }
}
