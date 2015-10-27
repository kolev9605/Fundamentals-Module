package com.company;

import java.util.Scanner;

public class HitTheTarget {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int target = Integer.parseInt(sc.nextLine());
        for (int i = 1; i <= 20; i++) {
            for (int j = 1; j<=20; j++){
                if (i+j==target){
                    System.out.printf("%d + %d = %d\r\n", i,j,target);
                } else if (i-j==target){
                    System.out.printf("%d - %d = %d\r\n", i,j,target);
                } else if (j-i==target){
                    System.out.printf("%d - %d = %d\r\n", j,i,target);
                }
            }
        }
    }
}
