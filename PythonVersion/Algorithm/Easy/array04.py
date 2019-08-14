# 存在重复
# 给定一个整数数组，判断是否存在重复元素。
# 如果任何值在数组中出现至少两次，函数返回 true。如果数组中每个元素都不相同，则返回 false。


# 时间超限
from typing import List

class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        for i in nums:
            if nums.count(i)>1:
                return True
        return False