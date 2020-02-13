class Solution:
    def numberOfSteps (self, num: int) -> int:
        steps = 0
        while num > 0:
            """
				If number is Even means We Can Do Division in 1 step
				However, If it is odd It is 2 steps (1 Subtract and 1 Division)
				Beware: For number `1` though just subtract will give you `0` so it is same as divisible by 2 (Just 1 step)
			"""
			if num % 2 == 0 or num == 1:
                steps += 1
            else:
                steps += 2
            num = num // 2
        
        return steps

# Normal Solution
   def numberOfSteps_2 (self, num: int) -> int:
        count = 0
        while num >0:
            if (num % 2) == 0:
                num = num/2
                count += 1
            else:
                num = num -1
                count +=1
        return count
