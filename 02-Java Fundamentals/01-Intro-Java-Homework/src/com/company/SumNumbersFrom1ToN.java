package com.company;

import java.util.Scanner;

public class SumNumbersFrom1ToN {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int sum = 0;
        int number = Integer.parseInt(sc.nextLine());
        for (int i = 0; i <= number; i++) {
            sum+=i;
        }
        System.out.println(sum);
    }
}
