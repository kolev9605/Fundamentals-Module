package com.company;

import java.util.Scanner;

public class GhettoNumeralSystem {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int number = Integer.parseInt(sc.nextLine());
        String result = "";
        while (number!=0){
            int currentLastDigit = number%10;
            switch (currentLastDigit){
                case 0:{
                    result = "Gee"+result;
                    break;
                }
                case 1:{
                    result = "Bro"+result;
                    break;
                }
                case 2:{
                    result = "Zuz"+result;
                    break;
                }
                case 3:{
                    result = "Ma"+result;
                    break;
                }
                case 4:{
                    result = "Duh"+result;
                    break;
                }
                case 5:{
                    result = "Yo"+result;
                    break;
                }
                case 6:{
                    result = "Dis"+result;
                    break;
                }
                case 7:{
                    result = "Hood"+result;
                    break;
                }
                case 8:{
                    result = "Jam"+result;
                    break;
                }
                case 9:{
                    result = "Mack"+result;
                    break;
                }
            }
            number/=10;
        }
        System.out.println(result);


    }
}
