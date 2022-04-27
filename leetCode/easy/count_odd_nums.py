class Solution:
    def countOdds(self, low: int, high: int) -> int:
        sumOdd =0
        for i in range(low,high+1):
            if i%2 != 0:
                sumOdd +=1
        return sumOdd


print(Solution().countOdds(2,10))

# Optimized solution
class Solution:
    def countOdds(self, low: int, high: int) -> int:
        N = (high - low) // 2
        if (low % 2 != 0 or high % 2 != 0):
            N += 1
        return N
