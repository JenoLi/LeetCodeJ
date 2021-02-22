using System.Collections.Generic;

namespace First
{
    public class N216
    {
        public IList<IList<int>> result=new List<IList<int>>();
        public List<int> path=new List<int>();
        public int sum = 0;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="k">个数</param>
        /// <param name="n">目标和</param>
        /// <returns></returns>
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            BackTracking(k, n, 1);
            return result;
        }

        public void BackTracking(int k, int n,int startindex)
        {
            if (path.Count == k)
            {
                if(sum==n) 
                    result.Add(new List<int>(path));
                return;
            }

            for (int i = startindex; i <= 9-(k-path.Count); i++)
            {
                sum += i;
                path.Add(i);
                BackTracking(k,n,i+1);
                sum -= i;
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}