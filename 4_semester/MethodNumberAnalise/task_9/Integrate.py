class Integrate:
    a: float
    b: float
    h: float
    n: int

    def __int__(self, a, b, h):
        self.a = a
        self.b = b
        self.h = h
        self.n = int((self.b - self.a) / h)

    def rectangleMethodLeft(self, f) -> float:
        return (self.b - self.a) * f(self.a)

    def rectangleMethodRight(self, f) -> float:
        return (self.b - self.a) * f(self.b)

    def rectangleMethodMiddle(self, f) -> float:
        return (self.b - self.a) * f((self.a + self.b) / 2)

    def trapezoidMethod(self, f) -> float:
        return ((self.b - self.a) / 2.0) * (f(self.b) + f(self.a))

    def simpsonMethod(self, f) -> float:
        return ((self.b - self.a) / 6.0) * (f(self.a) + 4 * f((self.b + self.a) / 2) + f(self.b))

    def generalizedRectangleLeft(self, f) -> float:
        result = 0
        for i in range(0, self.n):
            result += f(self.a + i * self.h)
        return result * self.h

    def generalizedRectangleRight(self, f) -> float:
        result = 0
        for i in range(1, self.n + 1):
            result += f(self.a + i * self.h)
        return result * self.h

    def generalizedRectangleMiddle(self, f) -> float:
        result = f(self.a) / 2 + f(self.b) / 2
        for i in range(1, self.n):
            result += f(self.a + i * self.h)
        return result * self.h

    def generalizedTrapezoid(self, f) -> float:
        result = 0
        for i in range(1, self.n):
            result += f(self.a + i * self.h)
        return self.h * (f(self.a) + f(self.b)) / 2 + self.h * result

    def generalizedSimpson(self, f) -> float:
        first = 0.0
        second = 0.0
        for i in range(1, self.n + 1):
            if i <= self.n - 1:
                first += f(self.a + i * self.h)
            second += f(self.a + self.h * (i - 1/2))
        return (self.h / 6.0) * (f(self.a) + f(self.b) + 2.0 * first + 4.0 * second)

    def dimension(self, i) -> list:
        switcher = {
            3: [0.707107, 0, -0.707107],
            4: [0.794654, 0.187592, -0.187592, -0.794654],
            5: [0.832498, 0.374541, 0, -0.374541, -0.832498],
            6: [0.866247, 0.422519, 0.266635, -0.266635, -0.422519, -0.866247],
            7: [0.883862, 0.529657, 0.323912, 0, -0.323912, -0.529657, -0.883862],
            9: [0.911589, 0.601019, 0.528762, 0.167906, 0, -0.167906, -0.528762, -0.601019, -0.911589]
        }
        return switcher.get(i, [])

    def chebyshev(self, f, n) -> float:
        t = self.dimension(n)
        result = 0
        if len(t) != 0:
            for i in range(n):
                x = 0.5 * ((self.b + self.a) + (self.b - self.a) * t[i])
                result += f(x)
            return result * (self.b - self.a) / n
        return -1
