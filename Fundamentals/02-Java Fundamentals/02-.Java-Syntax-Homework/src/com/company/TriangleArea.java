package com.company;

import java.util.Scanner;

public class TriangleArea {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int ax = sc.nextInt();
        int ay = sc.nextInt();

        int bx = sc.nextInt();
        int by = sc.nextInt();

        int cx = sc.nextInt();
        int cy = sc.nextInt();

        System.out.println(calculateTheArea(ax,ay,bx,by,cx,cy));
    }
    static int calculateTheArea (int ax, int ay, int bx, int by, int cx, int cy){
        //int area = (Math.abs((ax*(by-cy)+bx*(cy-ay)+cy*(ay-by))/2));
        // I have no idea why this is not working
        int area =  Math.abs(((bx-ax)*(cy-ay)-(cx-ax)*(by-ay))/2);
        // I have no idea why this IS working
        return area;
    }
}
