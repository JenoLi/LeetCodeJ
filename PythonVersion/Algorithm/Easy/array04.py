# 存在重复
# 给定一个整数数组，判断是否存在重复元素。
# 如果任何值在数组中出现至少两次，函数返回 true。如果数组中每个元素都不相同，则返回 false。
# 思路：1、计算元素在数组中出现的次数list.count()  2、转存到set中，判断长度（set不包含重复元素）


from typing import List

# 时间超限
# class Solution:
#     def containsDuplicate(self, nums: List[int]) -> bool:
#         for i in nums:
#             if nums.count(i)>1:
#                 return True
#         return False

class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        return len(set(nums))!=len(nums)



obj=Solution()
print(obj.containsDuplicate([1,3,4,2]))