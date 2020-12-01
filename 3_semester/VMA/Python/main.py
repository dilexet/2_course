from random import randint
import numpy as np
import time

start = time.time()

A = np.array([[randint(1, 9), randint(1, 9), randint(1, 9)],
              [randint(1, 9), randint(1, 9), randint(1, 9)],
              [randint(1, 9), randint(1, 9), randint(1, 9)]])
s = np.array([0, 0, 0])
for i in range(3):
    for j in range(3):
        s[i] += A[i][j]
normA = max(s)
print(A)
print(s)
print(normA)

time.sleep(1)
end = time.time()
t = round(end - start, 5) - 1
t *= 1000
print("%.3f" % t, "ms")
