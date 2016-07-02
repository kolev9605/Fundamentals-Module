package com.company;

import java.text.MessageFormat;
import java.util.Scanner;

public class GetAverage {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        double firstNum = Double.parseDouble(sc.nextLine());
        double secondNum = Double.parseDouble(sc.nextLine());
        double thirdNum = Double.parseDouble(sc.nextLine());
        calculateAverage(firstNum,secondNum,thirdNum);
    }
    public static void calculateAverage(double firstNum, double secondNum, double thirdNum) {
        System.out.println(String.format("%.2f",(firstNum+secondNum+thirdNum)/3));
    }
}
