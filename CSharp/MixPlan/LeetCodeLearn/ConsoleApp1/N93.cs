using System;
using System.Collections.Generic;

namespace First
{
    public class N93
    {
        List<string> result=new List<string>();
        public IList<string> RestoreIpAddresses(string s) {
            result.Clear();
            BackTracking(s,0,0);
            return result;
        }

        public void BackTracking(string s,int startindex,int pointnum)
        {
            if (pointnum == 3)
            {
                if (IsValid(s, startindex, s.Length - 1))
                {
                    result.Add(s);
                }
                return;
            }

            for (int i = startindex; i < s.Length; i++)
            {
                if (IsValid(s, startindex, i))
                {
                    s=s.Insert(i + 1, ".");
                    pointnum++;
                    BackTracking(s,i+2,pointnum);
                    pointnum--;
                    s=s.Remove(i + 1, 1);
                    // s=s.Remove(s.LastIndexOf('.'),1);//同理
                }
                else
                {
                    break;
                }
            }
        }

        private bool IsValid(string s,int startindex,int endindex)
        {
            if (startindex > endindex)
                return false;
            if (s[startindex] == '0' && startindex != endindex)
                return false;
            int num = 0;
            for (int i = startindex; i <= endindex; i++)//注意点：左右闭合区间
            {
                if (s[i] > '9' || s[i] < '0')
                {
                    return false;
                }
                num = num * 10 + (s[i] - '0');
                if (num > 255)
                {
                    return false;
                }
            }
            return true;
        }
    }
}