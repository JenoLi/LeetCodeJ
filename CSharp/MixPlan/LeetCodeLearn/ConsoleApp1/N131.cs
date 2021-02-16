using System;
using System.Collections.Generic;
using System.Linq;

namespace First
{
    public class N131
    {
        IList<IList<string>> result=new List<IList<string>>();
        List<string> subresult=new List<string>();//回文
        
        public IList<IList<string>> Partition(string s) {
            result.Clear();
            subresult.Clear();
            BackTracking(s, 0);
            return result;
        }

        private void BackTracking(string _str,int _startindex)
        {
            if (_startindex >= _str.Length)
            {
                result.Add(new List<string>(subresult));//需要先new再add，否则result为空
                return;
            }

            for (int i = _startindex; i < _str.Length; i++)
            {
                if (isPalindrome(_str, _startindex,i))
                {
                    string sub = _str.Substring(_startindex, i-_startindex + 1);
                    subresult.Add(sub);
                }
                else
                {
                    continue;
                }
                BackTracking(_str,i+1);
                subresult.RemoveAt(subresult.Count-1);
            }
            
        }
        
        private bool isPalindrome(string _str,int _startindex,int _endindex)
        {
            for (int i = _startindex, j = _endindex; i < j; i++, j--)
            {
                if (_str[i] != _str[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}