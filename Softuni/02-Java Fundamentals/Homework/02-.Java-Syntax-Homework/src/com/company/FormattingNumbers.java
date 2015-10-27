package com.company;

import java.util.Scanner;


import java.util.Scanner;

public class FormattingNumbers {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int a = Integer.parseInt(sc.nextLine());
        double b = Double.parseDouble(sc.nextLine());
        double c = Double.parseDouble(sc.nextLine());
        String unpaddedBinary = Integer.toBinaryString(a);

        String binary = String.format("%10s", unpaddedBinary).replace(' ', '0');

        System.out.printf("|%-10X|%s|%10.2f|%-10.3f|", a, binary, b, c);
    }
}
