# 买卖股票的最佳时机 II
#   给定一个数组，它的第 i 个元素是一支给定股票第 i 天的价格。
#   设计一个算法来计算你所能获取的最大利润。你可以尽可能地完成更多的交易（多次买卖一支股票）。
#   [7,1,5,3,6,4]  输出: 7
# 思路：
# 1.贪心
# 2.动态规划


from typing import List

# 贪心
class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        listlen=len(prices)
        if listlen<1:
            return 0
        profit=0
        for i in range(listlen-1):
            if prices[i] < prices[i+1]:
                profit+=prices[i+1]-prices[i]
        return profit

obj=Solution()
print(obj.maxProfit([7,6,4,3,1]))