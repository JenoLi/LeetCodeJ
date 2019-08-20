#coding=utf-8
'''
author:Jeno
function:
两个数组的交集 II
给定两个数组，编写一个函数来计算它们的交集。
输入: nums1 = [1,2,2,1], nums2 = [2,2]
输出: [2,2]
思路:
    1.用一个字典记录num1中元素出现的次数，之后以num2中的元素为key，判断字典中此key的值是否存在
'''
# from collections import defaultdict
import collections
from typing import List


class Solution:
    def intersect(self, nums1: List[int], nums2: List[int]) -> List[int]:
        num1dic=collections.defaultdict(int)
        ans=list()
        for i in nums1:
            num1dic[i]+=1
        for j in nums2:
            if num1dic[j]!=0:
                ans.append(j)
                num1dic[j]-=1
        return ans

obj=Solution()
print(obj.intersect([1,2,2,1],[2,2]))