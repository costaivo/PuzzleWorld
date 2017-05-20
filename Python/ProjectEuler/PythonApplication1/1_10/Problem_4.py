
"""
Problem 4 : Largest palindrome product
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.
"""
def check_if_palindrome(n):
    string = str(n)
    length = len(string)
    counter = 0
    while (counter < (length-1)-counter):
        if(string[counter] != string[(length-1)-counter]):
            return False
        counter=counter +1
    return True
        
def largest_palindrome():
    digit_1 = 100
    digit_2 =100
    max_3_digit_palindrome =0
    while (digit_1 <= 999):
        while (digit_2 <= 999):
            product = digit_1 * digit_2
            if(check_if_palindrome(product)):
                if(product > max_3_digit_palindrome):
                    max_3_digit_palindrome  = product
            digit_2 = digit_2+1
        digit_2=100
        digit_1 = digit_1+1
    return max_3_digit_palindrome


if __name__ =="__main__":
    print (largest_palindrome())


