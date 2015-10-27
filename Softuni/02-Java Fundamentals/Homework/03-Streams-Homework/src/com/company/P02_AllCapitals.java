package com.company;

import java.io.*;

public class P02_AllCapitals {
    public static void main(String[] args) {
        File file = new File("res/lines.txt");
        StringBuilder sb = new StringBuilder();
        try (BufferedReader br = new BufferedReader(
                                    new FileReader(file))) {
                String line = br.readLine();
                while(line!=null){
                    sb.append(line.toUpperCase()+"\n");
                    line = br.readLine();
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
        try (BufferedWriter bw = new BufferedWriter(
                                    new FileWriter(file))){
            bw.write(sb.toString());
        } catch (IOException e) {
            e.printStackTrace();
        }

    }
}
