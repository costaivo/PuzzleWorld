"""
Problem 3 : Largest prime factor
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?
"""


def get_prime_numbers(start,count):
    list_primes = []
    prime_count =0
    i=start
    while prime_count < count :
        if(is_prime_number(i)):
            list_primes.append(i);
            prime_count = prime_count+1
        i = i+1
    return list_primes

def is_prime_number(n):
        if(n==1 or n ==0):
            return False

        if(n % 2 == 0 and n != 2):
            return False
        elif (n==2):
            return True

        for j in range(3,10000000):
            if(n % j == 0 and n !=j):
                return False
            elif n==j:
                return True
        return True


def print_max_prime_factors(n):
    primes = get_prime_numbers(0,5)
    print(primes)
    prev_num=n
    condition = True
    all_primes    =[]
    max_prime=0
    while condition:
        prev_num    =n
        for num in primes:
            if (n % num == 0):
                print (num)
                if(num > max_prime):
                    max_prime =num
                    print('----------------------NEW MAX PRIME FOUND ---------- %d' % max_prime)
                    primes = all_primes
                n= n/num
                break;
        if (n == prev_num):
            new_primes = get_prime_numbers(primes[-1],10)
            all_primes = all_primes+new_primes
            primes = new_primes

        if(n <= 1):
            condition =False
    print ('Done Executing. Max Prime %d' % max_prime)

if __name__ =="__main__":
    print_max_prime_factors(600851475143)
 