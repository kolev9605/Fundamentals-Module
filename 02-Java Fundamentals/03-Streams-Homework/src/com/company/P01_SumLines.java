package com.company;

import java.io.*;

public class P01_SumLines {

    public static void main(String[] args) {
        File file = new File("res/lines.txt");

        try (BufferedReader br = new BufferedReader(
                                    (new FileReader(file)))){
            String line = br.readLine();
            while (line!=null){
                System.out.println(line);
                line = br.readLine();
            }
        } catch (IOException e) {
            e.printStackTrace();
        }

    }
}
