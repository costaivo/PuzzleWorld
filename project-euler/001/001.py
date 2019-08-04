
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
