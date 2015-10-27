package com.company;

import java.util.Scanner;

public class CharacterMultiplier {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String firstString = sc.nextLine();
        String secondString = sc.nextLine();
        System.out.println(stringCalc(firstString,secondString));
    }
    static int stringCalc (String str1, String str2){
        int sum = 0;

        if  (str1.length()>str2.length()){
                for (int i = 0; i < str2.length(); i++) {
                    sum+=str1.charAt(i)*str2.charAt(i);
                }
                for (int i = str2.length(); i < str1.length(); i++) {
                    sum+= str1.charAt(i);
                }
        } else if (str2.length()>str1.length()) {
            for (int i = 0; i < str1.length(); i++) {
                sum+=str2.charAt(i)*str1.charAt(i);
            }
            for (int i = str1.length(); i < str2.length(); i++) {
                sum+= str2.charAt(i);
            }
        } else {
            for (int i = 0; i < str1.length(); i++) {
                sum+=str1.charAt(i)*str2.charAt(i);
            }
        }
        return sum;
    }

}
