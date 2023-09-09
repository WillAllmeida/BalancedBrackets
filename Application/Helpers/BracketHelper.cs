using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Helpers
{
    public class BracketHelper
    {
        public static bool IsBalanced(string input)
        {
            Stack<char> result = new Stack<char>();

            foreach (char c in input)
            {
                if (c == '{' || c == '[' || c == '(')
                {
                    result.Push(c);
                }
                else if (c == '}' || c == ']' || c == ')')
                {
                    if (result.Count <= 0)
                    {
                        return false;
                    }

                    char top = result.Pop();

                    if ((c == ')' && top != '(') ||
                    (c == ']' && top != '[') ||
                    (c == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }

            return result.Count == 0 ? true : false;
        }
    }
}
