from Integrate import Integrate
from numpy import cos, exp


def main():
    print("[Task #1]:\n")
    solveFirstTask()
    print("\n[Task #2]:\n")
    solveSecondTask()


def solveFirstTask():
    integrate.__int__(-10, -7, 0.1)
    print("Метод левых прямоугольников:\t", integrate.rectangleMethodLeft(p))
    print("Метод правых прямоугольников:\t", integrate.rectangleMethodRight(p))
    print("Метод средних прямоугольников:\t", integrate.rectangleMethodMiddle(p))
    print("Метод трапеций:\t", integrate.trapezoidMethod(p))
    print("Метод симпсона:\t", integrate.simpsonMethod(p))
    print("Обобщённый метод левых прямоугольников:\t", integrate.generalizedRectangleLeft(p))
    print("Обобщённый метод правых прямоугольников:\t", integrate.generalizedRectangleRight(p))
    print("Обобщённый метод средних прямоугольников:\t", integrate.generalizedRectangleMiddle(p))
    print("Обобщённый метод трапеций:\t", integrate.generalizedTrapezoid(p))
    print("Обобщённый метод симпсона:\t", integrate.generalizedSimpson(p))


def solveSecondTask():
    for i in range(2, 11, 2):
        integrate.__int__(-1.7, 0, 1.7 / i)
        print("[n = ", i, "]: ")
        print("Метод трапеции:\t", integrate.generalizedTrapezoid(f))
        print("Метод Симпсона:\t", integrate.generalizedSimpson(f))
    print("\n[Метод Чебышева]:")
    for i in range(3, 10):
        if i != 8:
            integrate.__int__(-1.7, 0, 1.7 / i)
            print("[i = ", i, "] -", integrate.chebyshev(f, i))


def p(x: float) -> float:
    result = 0
    for i in range(5):
        result += (x ** i) * coeffs[i]
    return result


def f(x: float) -> float:
    return (cos(x) - x) * exp(x ** 2)


coeffs = [1.3, 0, -0.1, 0.7, 8.1]
integrate = Integrate()
main()
