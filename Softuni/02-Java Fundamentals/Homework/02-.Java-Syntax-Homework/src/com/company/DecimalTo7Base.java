package com.company;

import java.util.Scanner;

public class DecimalTo7Base {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String number = sc.nextLine();
        System.out.println(Integer.toString(Integer.parseInt(number, 10), 7));

    }
}
