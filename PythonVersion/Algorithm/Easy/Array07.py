#coding=utf-8
'''
author:Jeno
function:加一
给定一个由整数组成的非空数组所表示的非负整数，在该数的基础上加一。
最高位数字存放在数组的首位， 数组中每个元素只存储单个数字。
你可以假设除了整数 0 之外，这个整数不会以零开头。
输入: [1,2,3]
输出: [1,2,4]
解释: 输入数组表示数字 123。
思路：
    注意点：进位

'''
from typing import List


class Solution:
    def plusOne(self, digits: List[int]) -> List[int]:
        lenD=len(digits)
        for i in range(lenD-1,-1,-1):
            digits[i]+=1
            digits[i]=digits[i]%10
            if digits[i]!=0:
                return digits
        digits=[0]*(lenD+1)
        digits[0]=1
        return  digits


o=Solution()
# o.plusOne([1,2,3])
print(o.plusOne([8,9,9]))
