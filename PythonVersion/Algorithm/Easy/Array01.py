# 从排序数组中删除重复项
# 思路：两个指针一前一后遍历，当low指针小于high指针时，low指针+1，并且low+1指向high（即把大值复制到当前低值位）

from typing import List

class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        if not nums: return 0
        low=0
        for high in range(1,len(nums)):
            if nums[low]<nums[high]:
                low+=1
                nums[low]=nums[high]
        return low+1




obj=Solution()
print(obj.removeDuplicates([1,1,2]))
