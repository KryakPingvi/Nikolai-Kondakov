def func(N):
    if N > 5:
        if N % 2 == 0:
            return 2*func(N // 2)
        else:
            return func(N//2) + func((N+1)//2)
    if (N == 3) or (N == 5):
        return True
    else:
        return False


print(func(1024))





