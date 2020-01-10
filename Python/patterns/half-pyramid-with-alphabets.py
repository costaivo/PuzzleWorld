count = int(input('Enter the max number of Alphabets to print on the last row? --> '))
for i in range(1, count + 1):
    for j in range(65, 65 + i):
        print(chr(j), end =' ')
    print(' ')
