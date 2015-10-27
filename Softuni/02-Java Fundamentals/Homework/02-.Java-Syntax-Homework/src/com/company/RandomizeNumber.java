package com.company;


import java.util.*;

public class RandomizeNumber {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int minNumber = Integer.parseInt(sc.nextLine());
        int maxNumber = Integer.parseInt(sc.nextLine());
        ArrayList<Integer> added = new ArrayList<>();
        int count = 0;
        while(count!=maxNumber-minNumber+1){
            int currentRandom = minNumber + (int)(Math.random() * ((maxNumber - minNumber) + 1));
            if (!added.contains(currentRandom)){
                added.add(currentRandom);
                System.out.print(currentRandom+" ");
                count++;
            }
        }
    }
}
