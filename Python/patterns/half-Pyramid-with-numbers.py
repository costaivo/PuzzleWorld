count = int(input('Enter the number of columns you want to print in the last row? --> '))
for i in range(1, count + 1):
    for j in range(1, i + 1):
        print(j,end=' ')
    print('')
