using System;

namespace First
{
    public class N455
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="g">胃口</param>
        /// <param name="s">饼干</param>
        /// <returns></returns>
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            int count = 0;
            int index = s.Length - 1;

            for (int i = g.Length - 1; i >= 0; i--)
            {
                if (s[index] >= g[i] && index>=0)
                {
                    count++;
                    index--;
                }
            }
            return count;
        }
    }
}