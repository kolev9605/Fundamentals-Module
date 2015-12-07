package com.company;

import java.util.*;

public class MagicExchangeableWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split(" ");
        String str1 = input[0];
        String str2 = input[1];

        System.out.println(areExchangeable(str1,str2));
    }
    static boolean areExchangeable (String str1, String str2){
        HashMap<Character,Character> stringData = new HashMap<>();
        for (int i = 0; i < str1.length(); i++) {
            if (!stringData.containsKey(str1.charAt(i))){
                stringData.put(str1.charAt(i),str2.charAt(i));
        } else  {
                if (stringData.get(str1.charAt(i))!=str2.charAt(i)){
                    return false;
                }
            }

        }
        return true;
    }
}
