k=5 #высота
l=10 #длина
p=7 #расстояние до колодца
n=20 #кол во грядок
M=0


M=2*n*(p+k+l)+2*n*(n-1)*l//2

def ans_1(k,l,p,n):
    S=0
    for i in range(n):
        S+=2*(p+k+l)+2*i*l
    return S

print(M,ans_1(k,l,p,n))

