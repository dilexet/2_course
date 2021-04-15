import matplotlib.pyplot as plt
from numpy import arange


def main():
    Prepare()
    print(f(0.21335))
    CreatePlot()


def Prepare():
    global x, y, a1, a2
    a1 = [(y[1] - y[0]) / (x[1] - x[0])]
    for i in range(len(x) - 1):
        a1.append(2 * (y[i + 1] - y[i]) / (x[i + 1] - x[i]) - a1[i])
    for i in range(len(x) - 1):
        a2.append((a1[i + 1] - a1[i]) / (2 * (x[i + 1] - x[i])))


def f(k: float) -> float:
    global x
    for i in range(len(x) - 1):
        if x[i] <= k <= x[i + 1]:
            return round(ParabolicSplinePolynom(k, i), 5)
    if k <= x[0]:
        return round(ParabolicSplinePolynom(k, 0), 5)
    if k >= x[int(len(x)-1)]:
        return round(ParabolicSplinePolynom(k, len(x) - 2), 5)
    return -1


def ParabolicSplinePolynom(k: float, i: int) -> float:
    global x, y, a1, a2
    return y[i] + a1[i] * (k - x[i]) + a2[i] * (k - x[i]) ** 2


def CreatePlot():
    global x, y
    plt.plot(x, y, 'bo', label="points")
    for i in range(len(x) - 1):
        k = arange(x[i], x[i + 1], 0.001)
        plt.plot(k, ParabolicSplinePolynom(k, i), color="red")
    plt.legend()
    plt.show()


a1 = []
a2 = []
x = [0.0, 0.5, 1.0, 1.5, 2.0, 2.5, 3.0, 3.5, 4.0, 4.5]
y = [0.0, 0.35, 0.8, 0.95, 0.98, 0.95, 0.8, 0.35, 0.1, 0.0]
main()
input()
