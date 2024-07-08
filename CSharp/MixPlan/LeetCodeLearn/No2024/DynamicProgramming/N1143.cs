using System;

namespace No2023.DynamicProgramming
{
    public class N1143
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            int[,] dp = new int[text1.Length + 1, text2.Length + 1];

            char[] t1 = text1.ToCharArray();
            char[] t2 = text2.ToCharArray();
            
            
            for (int i = 0; i <= text1.Length; i++) dp[i, 0] = 0;
            for (int i = 0; i <= text2.Length; i++) dp[0, i] = 0;

            int res = 0;
            
            for(int i=1;i<=text1.Length;i++)
            {
                for(int j=1;j<=text2.Length;j++)
                {
                    if (t1[i - 1] == t2[j - 1])
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    else
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);

                    if (dp[i, j] > res)
                        res = dp[i, j];
                }
            }

            return res;
        }
    }
}

