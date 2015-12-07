package com.company;

import java.util.Scanner;

public class CalculateExpression {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double a = Double.parseDouble(sc.nextLine());
        double b = Double.parseDouble(sc.nextLine());
        double c = Double.parseDouble(sc.nextLine());
        double averageOfNumbers = (a+b+c)/3.0;
        double averageOfFormulas = (firstFormula(a,b,c)+secondFormula(a,b,c))/2.0;
        double result = Math.abs(averageOfNumbers-averageOfFormulas);
        System.out.printf("F1 result: %.2f F2 result: %.2f; Diff: %.2f",firstFormula(a,b,c),secondFormula(a,b,c),result);
    }
    static double firstFormula (double a, double b, double c){
        double main = ((Math.pow(a,2)+Math.pow(b,2))/(Math.pow(a,2)-Math.pow(b,2)));
        double power = ((a+b+c)/Math.sqrt(c));
        return Math.pow(main,power);
        }
    static double secondFormula (double a, double b, double c){
        double main = (a*a+b*b-c*c*c);
        double power = a-b;
        return Math.pow(main,power);
    }
}
