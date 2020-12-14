import numpy as np
import sympy as sp


a = [
    [5, 2, 5],
    [6, 9, 1],
    [9, 1, 7]
]

#a = \
#[
#[2, 1],
#[9, 2]
#]

a = np.array(a, dtype=np.float)
print(a)

def sum_of_squares(a):
    s = 0
    for i in a:
        s += i**2
    return s

def b_matrix(a, i):
    b = np.identity(a.shape[0])
    for j in range(a.shape[1]):
        if(j == i):
            b[i][j] = 1/a[i+1][i]
        else:
            b[i][j] = - a[i+1][j]/a[i+1][i]
    return b


def frobenius(a):
    d = a
    for i in range(d.shape[0] - 2, -1, -1):
        b = b_matrix(d, i)
        d = np.linalg.multi_dot([np.linalg.inv(b), d, b])

    return d

def str_equation(frob):
    eq = '{}*x**{}'.format(-1**frob.shape[0], frob.shape[1])
    for i in range(frob.shape[1]):
        eq += "{:+f}*{}".format(-1 * -1**frob.shape[0] * frob[0][i], 'x**{}'.format(frob.shape[1]-1-i))

    return eq

# print(b_matrix(a, 1))

x = sp.symbols('x')
frob = frobenius(a)
eq = sp.sympify(str_equation(frob))
eigenvalues = list(sp.solveset(eq, x))
print("Frobenius matrix: ")
print(frob)
print()

print("Equation: ")
print(eq)
print()
print("Eigenvalues: ")
print(eigenvalues)
print()

print("Checks:\n")
print("tr(A) = sum of eigenvalues check")
print(sum(eigenvalues), a.trace())
print("det(A) = product of eigenvalues check")
print(np.product(eigenvalues), np.linalg.det(a))
print("tr(A^2) = sum of squared eigenvalues check")
print(sum_of_squares(eigenvalues), np.dot(a, a).trace())

print()
print("det(A - eigens * E) = 0 check")
check = a - np.diag(eigenvalues)
check = np.array(check, dtype=np.float)
print(check)
print(np.linalg.det(check))
# print(sp.sympify(str_equation(frobenius(a))))
