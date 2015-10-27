package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class P01_SortArrayOfNumbers {
        public static void main(String[] args) {
                Scanner sc = new Scanner(System.in);
                int n = Integer.parseInt(sc.nextLine());
                int[] arr = new int[n];
                for (int i = 0; i < n; i++) {
                        int number = sc.nextInt();
                        arr[i] = number;
                }
                Arrays.sort(arr);
                for (int i : arr) {
                        System.out.print(i+" ");
                }
        }
}
