def main():
    A = int(input())
    fib = [0] * (A + 1)
    fib[1] = 1

    for i in range(2, A + 1):
        fib[i] = fib[i - 1] + fib[i - 2]

    print(fib[A])


if __name__ == "__main__":
    main()
