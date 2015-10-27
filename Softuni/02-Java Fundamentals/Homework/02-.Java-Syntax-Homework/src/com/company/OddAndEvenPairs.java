package com.company;

import java.util.Scanner;

public class OddAndEvenPairs {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split(" ");
        if (input.length%2!=0){
            System.out.println("Invalid lenght");
        } else {
            for (int i = 1; i < input.length-1; i++) {
                int firstNum = Integer.parseInt(input[i-1]);
                int secondNum = Integer.parseInt(input[i]);
                if (firstNum%2==0&&secondNum%2==0){
                    System.out.printf("%d, %d -> both are even\n", firstNum, secondNum);
                } else if (firstNum%2!=0&&secondNum%2!=0) {
                    System.out.printf("%d, %d -> both are odd\n", firstNum, secondNum);
                } else {
                    System.out.printf("%d, %d -> different\n", firstNum, secondNum);
                }
            }
        }
    }
}
