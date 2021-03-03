package com.grsu.pm;

public class Main {

    public static void main(String[] args) {
        double x0 = 0;
        double x1 = 2;
        double e = 0.00001;
        System.out.println("\nМетод хорд\n");
        System.out.println(MethodHoard.find(x0, x1, e));
        System.out.println("\nМетод Эйткена\n");
        System.out.println(AitkenMethod.find(x0, e));
        System.out.println("\nМетод Стеффенсона\n");
        System.out.println(SteffancenMethod.find(x0, e));
    }
}
