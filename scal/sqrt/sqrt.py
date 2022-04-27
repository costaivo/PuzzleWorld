def squareRoot(num):
    left = 0
    right =num
    mid =(left+right)/2 
    sq = mid * mid  
    while abs(sq-num) >0.00000000000001:
        print(left,right,mid,sq,num)
        if sq < num:
            left =mid
        else:   
            right = mid
        mid =(left+right)/2
        sq = mid*mid
    return mid


print('100 sqrt-->',squareRoot(100))
print('-----------------')
print('101 sqrt-->',squareRoot(101))


# optimized solution using binary search
def squareRootoptimized(num):
    print('todo')