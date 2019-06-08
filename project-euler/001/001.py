"""
Problem 1 : Multiples of 3 and 5
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.
"""
def find_natural_numbers(n):
    i=1
    sum=0
    while(i<n):
        if((i % 3) == 0):
            sum = sum + i
        elif ((i % 5) ==0):
            sum = sum +i
        i =i+1
    return sum


if __name__ =="__main__":
    print (find_natural_numbers(1000))
