namespace No2023.DynamicProgramming
{
    public class N718
    {
        public int FindLength(int[] nums1, int[] nums2)
        {
            //O(n*m) 
            //通过二维数组分析(等比成二维矩阵表示容易理解）
            int[,] dp = new int[nums1.Length+1, nums2.Length+1];//dp[i,j] 代表第[i-1,j-1]的最长子数组长度

            int res = 0;
            for (int i = 0; i <= nums1.Length; i++) dp[i, 0] = 0;
            for (int i = 0; i <= nums2.Length; i++) dp[0, i] = 0;

            for (int i = 1; i <= nums1.Length; i++)
            {
                for (int j = 1; j <= nums2.Length; j++)
                {
                    if(nums1[i-1]==nums2[j-1])//dp数组代表的含义 所以需要-1
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    if (dp[i, j] > res)
                        res = dp[i, j];
                }
            }

            return res;
        }
    }
}