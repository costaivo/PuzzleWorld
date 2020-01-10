count = int(input('Enter the max number of "*" you want to print on the last row? -->'))
for i in range(1, count + 1):
    for j in range(1, i +1):
        print('*', end=' ')
    print(' ')
