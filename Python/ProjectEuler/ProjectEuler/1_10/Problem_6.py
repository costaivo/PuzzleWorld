"""
Problem 5 : Sum square difference
The sum of the squares of the first ten natural numbers is,

1'2 + 2'2 + ... + 10'2 = 385
The square of the sum of the first ten natural numbers is,

(1 + 2 + ... + 10)'2 = 55'2 = 3025
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
"""
def get_difference(n):
    sum_of_n = (n *(n+1))/2
    print (sum_of_n)
    square_of_sum_of_n = sum_of_n ** 2
    print (square_of_sum_of_n)
    square_of_n = (n*(n+1)*(2*n+1))/6
    diff =   square_of_sum_of_n -square_of_n
    return diff


if __name__=="__main__":
   print( get_difference(100))