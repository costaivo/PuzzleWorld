"""
Problem 5 : Smallest multiple
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
"""

#URL : https://www.algebra.com/algebra/homework/Sequences-and-series/Sequences-and-series.faq.question.839386.html

def gcd(a,b):
    if a % b == 0:
        return b
    else:
        return gcd(b,a%b)

def lcm(a,b):
    return a*b//gcd(a,b)





if __name__ =="__main__":
    leastCM = 1
    n = 20
    for i in range(2,n+1):
        leastCM = lcm(leastCM,i)
    print (leastCM)
   


