import matplotlib.pyplot as plt
from numpy import arange


def main():
    print(f(0.114))
    createPlot()


def createPlot():
    for i in range(len(points)):
        plt.plot(points[i][0], points[i][1], "bo")
    x = arange(0.02, 0.3, 0.001)
    plt.plot(x, f(x), label="Lagranzh Graph", color="red")
    plt.legend()
    plt.show()


def f(x: float) -> float:
    global points
    result = 0.0
    for i in range(len(points)):
        result += p(x, i) * points[i][1]
    return result


def p(x: float, index: int) -> float:
    global points
    result = 1
    for i in range(6):
        if i != index:
            result *= (x - points[i][0]) / (points[index][0] - points[i][0])
    return result


points = [[0.02, 1.02316], [0.08, 1.09590], [0.12, 1.14725], [0.17, 1.21483], [0.23, 1.30120], [0.3, 1.40976]]
main()
