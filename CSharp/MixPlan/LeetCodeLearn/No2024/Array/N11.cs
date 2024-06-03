using System;

namespace No2023.Array
{
    public class N11
    {
        public int MaxArea(int[] height)
        {
            int res = 0;
            int left = 0;
            int right = height.Length - 1;
            while (left<right)
            {
                int area = (right - left) * Math.Min(height[left], height[right]);
                res = Math.Max(area, res);
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return res;
        }
        
    }
}