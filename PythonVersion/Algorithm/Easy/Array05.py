# 只出现一次的数字
# 给定一个非空整数数组，除了某个元素只出现一次以外，其余每个元素均出现两次。找出那个只出现了一次的元素。
# 输入: [2,2,1]
# 输出: 1
# 思路：运用异或，相异为1(2进制1 十进制原本的数) 相同为0
# a⊕0=a ；a⊕a=0 ；a⊕b⊕a=(a⊕a)⊕b=0⊕b=b

from typing import List

class Solution:
    def singleNumber(self, nums: List[int]) -> int:
        ans=0
        for i in nums:
            ans^=i
        return ans

obj=Solution()
print(obj.singleNumber([1,1,3,4,4,2,2]))