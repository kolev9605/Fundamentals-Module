package com.company;

import java.util.Scanner;

public class SevenBaseToDecimal {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String number = sc.nextLine();
        System.out.println(Integer.toString(Integer.parseInt(number, 7), 10));
    }
}
