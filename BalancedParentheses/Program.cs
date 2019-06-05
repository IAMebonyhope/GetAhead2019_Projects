using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(balancedParenthesis("())()"));
            Console.WriteLine(balancedParenthesis(")(((()))))))((((()"));
            Console.WriteLine(balancedParenthesis("))))(((("));

            Console.ReadLine();
        }

        static int balancedParenthesis(string s)
        {
            int longest = 0;
            int charLength = 0;

            if(s.Length < 1)
            {
                return longest;
            }

            Stack<char> stack = new Stack<char>();

            for(int i=0; i<s.Length; i++)
            {
                char C = s[i];

                if (C == '(')
                {
                    stack.Push(C);
                    longest = compareLongest(longest, charLength);
                    charLength = 0;
                }
                else
                {
                    if (stack.LongCount() < 1)
                    {
                        stack.Push(C);
                        charLength = 0;
                    }
                    else
                    {
                        char T = stack.Peek();
                        if (T == '(')
                        {
                            charLength += 2;
                            stack.Pop();
                        }
                        else 
                        {
                            stack.Push(C);
                            longest = compareLongest(longest, charLength);
                            charLength = 0;
                        }
                    }
                    
                }
            }

            longest = compareLongest(longest, charLength);

            return longest;
        }

        static int compareLongest(int longest, int charLength)
        {
            if(longest < charLength)
            {
                return charLength;
            }
            else
            {
                return longest;
            }
        }
    }
}
