using System.Collections.Generic;

namespace First
{
    public class N77
    {
        public IList<IList<int>> result=new List<IList<int>>();
        List<int> subres=new List<int>();
        
        public IList<IList<int>> Combine(int n, int k)
        {
            BackTracking(n, k, 1);
            return result;
        }

        public void BackTracking(int n, int k,int startindex)
        {
            if (subres.Count == k)
            {
                result.Add(new List<int>(subres));
                return;
            }

            for (int i = startindex; i <= n; i++)
            {
                subres.Add(i);
                BackTracking(n,k,i+1);
                subres.RemoveAt(subres.Count-1);
            }
        }
    }
}