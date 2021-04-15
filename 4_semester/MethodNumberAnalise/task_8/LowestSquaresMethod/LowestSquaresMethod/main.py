import matplotlib.pyplot as plt
from Solve import LinearSolve, SquarePolynomSolve, HyperbolicSolve, NaturalLogaryphm, ExponentialSolve
from numpy import arange


def main():
    global lin
    Plot()


def Plot():
    global X, Y, lin
    x = arange(0.001, 8, 0.001)
    axes = plt.gca()
    axes.set_xlim([1, 7])
    axes.set_ylim([8, 29])
    plt.plot(X, Y, "bo", label="points")
    plt.plot(x, lin.f(x), label="linearGraph", color="green")
    plt.plot(x, sq.f(x), label="SquareGraph", color="grey")
    plt.plot(x, hyp.f(x), label="HyperbolicGraph", color="brown")
    plt.plot(x, nat.f(x), label="LogaryphmGraph", color="red")
    plt.plot(x, exp.f(x), label="ExponentialGraph", color="yellow")
    plt.legend()
    plt.show()


def f(x: float) -> float:
    return -0.5 * x + 3


X = [3.54, 4.29, 4.78, 3.99, 1.13, 6.29, 1.89, 3.27] # X = [1, 7]
Y = [22.81, 28.42, 24.95, 26.96, 8.78, 33.55, 15.77, 22.89] # Y = [8, 29]
#X = [5.46, 2.73, 6.49, 4.26, 2.39, 6.46, 0.86, 2.05] # X = [0, 7]
#Y = [65.72, 58.05, 60.05, 55.79, 50.83, 47.69, 44.49, 59.74] # Y = [40, 70]

lin = LinearSolve(X, Y)
sq = SquarePolynomSolve(X, Y)
hyp = HyperbolicSolve(X, Y)
nat = NaturalLogaryphm(X, Y)
exp = ExponentialSolve(X, Y)
main()
