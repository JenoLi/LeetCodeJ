#coding=utf-8
'''
author:Jeno
function: 移动零
    给定一个数组 nums，编写一个函数将所有 0 移动到数组的末尾，同时保持非零元素的相对顺序。
示例:
    输入: [0,1,0,3,12]
    输出: [1,3,12,0,0]
说明:
    必须在原数组上操作，不能拷贝额外的数组。
    尽量减少操作次数。
思路：
    双指针，一快一慢，快指针！=0时，和满指针交换->慢+1，继续快指针遍历
'''
from typing import List

class Solution:
    def moveZeroes(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        j = 0
        for i in range(len(nums)):
            if nums[i] != 0:
                nums[j], nums[i] = nums[i], nums[j]
                j += 1

numlist=[0,1,0,3,12]
obj=Solution()
obj.moveZeroes(numlist)
print(numlist)

