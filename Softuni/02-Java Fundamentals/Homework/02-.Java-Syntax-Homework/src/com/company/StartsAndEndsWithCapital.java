package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class StartsAndEndsWithCapital {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();

        Pattern capitalsPattern = Pattern.compile("(\\b[A-Z][a-zA-Z]*[A-Z]\\b)");

        Matcher matcher = capitalsPattern.matcher(input);

        while (matcher.find()) {
            System.out.print((matcher.group())+" ");
        }
    }
}



