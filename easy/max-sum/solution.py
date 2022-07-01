def sumMaxSubArray(arr):
    max_sum_overall = arr[0]
    sum_current = arr[0]

    for i in range(1,len(arr)):
        if sum_current >=0:
            sum_current +=arr[i]
        else:
            sum_current = arr[i]
        
        if sum_current > max_sum_overall:
            max_sum_overall = sum_current
        
    return max_sum_overall



print(sumMaxSubArray([0,-5,-6,1,2,-10]))



