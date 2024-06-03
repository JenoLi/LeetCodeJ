using System.Collections.Generic;

namespace No2023.Array
{
    public class N349
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            System.Array.Sort(nums1);
            System.Array.Sort(nums2);
            int index1 = 0;
            int index2 = 0;
            List<int> res = new List<int>();
            while (index1<nums1.Length &&  index2<nums2.Length)
            {
                if (nums1[index1] == nums2[index2])
                {
                    if(!res.Contains(nums1[index1]))
                        res.Add(nums1[index1]);
                    index1++;
                    index2++;
                }else if (nums1[index1] < nums2[index2])
                    index1++;
                else
                    index2++;
            }
            return res.ToArray();
        }
    }
}