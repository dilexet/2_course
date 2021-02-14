N, T = map(int, input().split())

List = [0] * N
for i in range(0, N):
    List[i] = i + 1

List = List[-T:] + List[:-T]

for i in range(0, N):
    print(List[i], end=' ')
