# 旋转数组
# 给定一个数组，将数组中的元素向右移动 k 个位置，其中 k 是非负数。
# 示例：
#   输入: [1,2,3,4,5,6,7] 和 k = 3
#   输出: [5,6,7,1,2,3,4]
#   解释:
#   向右旋转 1 步: [7,1,2,3,4,5,6]
#   向右旋转 2 步: [6,7,1,2,3,4,5]
#   向右旋转 3 步: [5,6,7,1,2,3,4]
# 思路：
#   点：元素直接移动到目标位置，需要缓存中间值
#   面：3次反转，反转[0,legth) 反转[0,k) 反转[k,length);;或直接用python的切片

from typing import List

class Solution:
    def rotate(self, nums: List[int], k: int) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """

        nums[:]=nums[len(nums) - k:]+nums[:len(nums) - k]
        print(nums)

        # 有BUG  [1,2] 2时  输出不对
        # nums.reverse()
        # temp = nums[0:k]
        # temp2 = nums[k:len(nums)]
        # temp.reverse()
        # temp2.reverse()
        # nums[:] = temp + temp2

nums=[1,2,3,4,5,6]
obj=Solution()
obj.rotate(nums,2)
print(nums)
