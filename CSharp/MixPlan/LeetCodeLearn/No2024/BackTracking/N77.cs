using System.Collections.Generic;

namespace No2024.BackTracking
{
    public class N77
    {
        List<int> path = new List<int>();
        List<IList<int>> res = new List<IList<int>>();
        
        public IList<IList<int>> Combine(int n, int k)
        {
            BackTracking(1, n, k);
            return res;
        }

        //1~n 范围   k 个数
        private void BackTracking(int start,int n,int k)
        {
            if (path.Count == k)
            {
                res.Add(path.ToArray());
                return;
            }

            for (int i = start; i <= n-(k-path.Count)+1; i++)
            {
                path.Add(i);
                BackTracking(i+1,n,k);
                path.RemoveAt(path.Count-1);
            }
        }
    }
}