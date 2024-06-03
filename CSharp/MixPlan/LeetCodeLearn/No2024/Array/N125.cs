using System;

namespace No2023.Array
{
    public class N125
    {
        public bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            char[] chars = s.ToCharArray();
            while (left<right)
            {
                char cl = chars[left];
                if (!check(cl))
                {
                    left++;
                    continue;
                }
                char cr = chars[right];
                if (!check(cr))
                {
                    right--;
                    continue;
                }
                if (trans(cl) != trans(cr))
                {
                    return false;
                }
                else
                {
                    left++;
                    right--;
                }
            }
            return true;
        }
        
        bool check(char ch) {
            return (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || (ch >= '0' && ch <= '9');
        }
        
        char trans(char ch) {
            if(ch >= '0' && ch <= '9') {
                return ch;
            }
           return Char.ToLower(ch);
        }
    }
}