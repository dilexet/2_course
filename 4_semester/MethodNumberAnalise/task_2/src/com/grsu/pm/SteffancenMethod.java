package com.grsu.pm;

public class SteffancenMethod {
    public static double find(double x0, double eps) {
        double x;
        int iteration = 0;
        do {
            x = x0 - Math.pow(f(x0), 2) / (f(x0) - f(x0 - f(x0)));
            x0 = x;
            iteration++;
        }
        while (Math.abs(f(x)) > eps);
        System.out.println("Iteration = " + iteration);
        return x;
    }

    private static double f(double x) {
        return x - Math.atan(1 / x);
    }
}
