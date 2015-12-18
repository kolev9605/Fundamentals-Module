package com.company;

import java.util.Scanner;

public class RectangleArea {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int a = Integer.parseInt(sc.nextLine());
        int b = Integer.parseInt(sc.nextLine());
        System.out.println(rectangleArea(a,b));
    }
    static int rectangleArea (int a, int b){
        return a*b;
    }
}
