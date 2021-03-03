package com.grsu.pm;

public class MethodHoard {

    public static double find(double x0, double x1, double eps) {
        double x = x1;
        int iter = 0;
        do {
            x = x - f(x) / (f(x) - f(x0)) * (x - x0);
            iter++;
        } while (Math.abs(f(x)) > eps);
        System.out.println("Iteration = " + iter);
        System.out.println("f(x) = " + f(x));
        return x;
    }
    private static double f(double x){
        return x - Math.atan(1 / x);
    }
}
