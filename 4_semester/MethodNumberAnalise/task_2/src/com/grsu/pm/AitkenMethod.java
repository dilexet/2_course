package com.grsu.pm;

public class AitkenMethod {
    public static double find(double x0, double eps) {
        double x, x1, x2, d;
        x = x0;
        int iteration = 0;
        do {
            x0 = x;
            x1 = fi(x0);
            x2 = fi(x1);
            d = x0 - 2 * x1 + x2;
            iteration++;
            if (d != 0) {
                x = (x0 * x2 - x1 * x1) / d;
            } else break;
        }
        while (Math.abs(x - x0) > eps);
        System.out.println("Iteration = " + iteration);
        return x;
    }

    private static double f(double x) {
        return x - Math.atan(1 / x);
    }

    private static double fi(double x) {
        double lambda = 2;
        return x - lambda * (x - Math.atan(1 / x));
    }
}
