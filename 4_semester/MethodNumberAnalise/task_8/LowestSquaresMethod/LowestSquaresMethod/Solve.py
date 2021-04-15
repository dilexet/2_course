import numpy as math


class LinearSolve:
    a = 0; b = 0

    def __init__(self, X: list, Y: list):
        a11 = len(X); a12 = 0.0; a22 = 0.0; c1 = 0.0; c2 = 0.0
        for i in range(len(X)):
            a12 += X[i]; a22 += X[i] ** 2; c1 += Y[i]; c2 += X[i] * Y[i]
        k = math.linalg.solve(math.array([[a11, a12], [a12, a22]]), math.array([c1, c2]))
        self.a = k[0]; self.b = k[1]

    def f(self, x: float) -> float:
        return self.b * x + self.a


class SquarePolynomSolve:
    a = 0; b = 0; c = 0

    def __init__(self, X: list, Y: list):
        A = []; B = []; C = []; D = []
        for j in range(3):
            A.append(0), B.append(0), C.append(0), D.append(0)
            for i in range(len(X)):
                A[j] += X[i] ** (4 - j); B[j] += X[i] ** (3 - j); D[j] += Y[i] * X[i] ** (2 - j)
                A[j] /= len(X); B[j] /= len(X); D[j] /= len(X)
                if j != 2: C[j] += X[i] ** (2 - j); C[j] /= len(X)
                else: C[j] = len(X)
        k = math.linalg.solve(math.array([A, B, C]), math.array([D[0], D[1], D[2]]))
        self.a = k[0]; self.b = k[1]; self.c = k[2]

    def f(self, x: float) -> float:
        return self.a * x ** 2 + self.b * x + self.c


class HyperbolicSolve:
    a = 0; b = 0

    def __init__(self, X: list, Y: list):
        a11 = len(X); a12 = 0.0; a22 = 0.0; c1 = 0.0; c2 = 0.0
        for i in range(len(X)):
            a12 += 1 / X[i]; a22 += (1 / X[i]) ** 2; c1 += Y[i]; c2 += Y[i] / X[i]
        k = math.linalg.solve(math.array([[a11, a12], [a12, a22]]), math.array([c1, c2]))
        self.a = k[0]; self.b = k[1]

    def f(self, x: float) -> float:
        return self.b / x + self.a


class NaturalLogaryphm:
    a = 0; b = 0

    def __init__(self, X: list, Y: list):
        a11 = len(X); a12 = 0.0; a22 = 0.0; c1 = 0.0; c2 = 0.0
        for i in range(len(X)):
            a12 += math.log(X[i]); a22 += (math.log(X[i])) ** 2; c1 += Y[i]; c2 += Y[i] * math.log(X[i])
        k = math.linalg.solve(math.array([[a11, a12], [a12, a22]]), math.array([c1, c2]))
        self.a = k[0]; self.b = k[1]

    def f(self, x: float):
        return math.log(x) * self.b + self.a


class ExponentialSolve:
    a = 0; b = 0

    def __init__(self, X: list, Y: list):
        a11 = len(X); a12 = 0.0; a22 = 0.0; c1 = 0.0; c2 = 0.0
        for i in range(len(X)):
            a12 += X[i]; a22 += X[i] ** 2; c1 += math.log(Y[i]); c2 += X[i] * math.log(Y[i])
        k = math.linalg.solve(math.array([[a11, a12], [a12, a22]]), math.array([c1, c2]))
        a0 = k[0]; self.b = k[1]; self.a = math.exp(a0)

    def f(self, x: float) -> float:
        return self.a * math.exp(self.b * x)
