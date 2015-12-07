package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class GetFirstOddOrEven {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split(" ");
        List<Integer> arr = new ArrayList<>();
        for (int i = 0; i < input.length; i++) {
            arr.add(Integer.parseInt(input[i]));
        }
        String[] command = sc.nextLine().split(" ");
        int n = Integer.parseInt(command[1]);
        String evenOrOdd = command[2];
        firstEvenOrOdd(n,evenOrOdd,arr);


    }
    static void firstEvenOrOdd (int n, String evenOrOdd, List<Integer> arr){
        boolean isEven = evenOrOdd.equals("even");
        if (isEven){
            for (int i = 0; i < n && i<arr.size(); i++) {
                if (arr.get(i)%2==0){
                    System.out.print(arr.get(i) + " ");
                }
            }
        } else {
            for (int i = 0; i < n && i<arr.size(); i++) {
                if (arr.get(i)%2!=0){
                    System.out.print(arr.get(i)+" ");
                }
            }
        }
    }
}