package com.company;

import java.io.*;

public class P04_CopyJpgFile {
    public static void main(String[] args) {
        /*try (
                BufferedReader bfr =
                        new BufferedReader(
                                new InputStreamReader(
                                        new FileInputStream("res/dog.jpg")));
                BufferedWriter bfw =
                        new BufferedWriter(
                                new OutputStreamWriter(
                                        new FileOutputStream("res/dog-copy.jpg")))
        ) {
            int i = bfr.read();
            bfw.write((char)i);
        } catch (IOException e1) {
            e1.printStackTrace();
        }
    } */
        //I have no idea why this is not working
        try (
                FileInputStream fis =
                        new FileInputStream("res/dog.jpg");
                FileOutputStream fos =
                        new FileOutputStream("res/dog-copy.jpg")
        ) {
            int i = fis.read();
            while (i != -1) {
                fos.write((char) i);
                i = fis.read();
            }
        } catch (IOException ioe) {
            System.out.println(ioe.toString());
        }
    }
}