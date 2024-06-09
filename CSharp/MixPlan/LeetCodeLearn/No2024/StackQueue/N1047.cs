using System.Collections.Generic;

namespace No2024.StackQueue
{
    public class N1047
    {
        public string RemoveDuplicates(string s)
        {
            Stack<char> stackC = new Stack<char>();
            string res = string.Empty;
            char[] ss= s.ToCharArray();
            foreach (char c in ss)
            {
                if (stackC.Count == 0 || c != stackC.Peek())
                {
                    stackC.Push(c);
                }
                else
                {
                    stackC.Pop();
                }
            }

            while (stackC.Count > 0)
            {
                res=stackC.Pop()+res;
            }

            return res;
        }
    }
}