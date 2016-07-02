package com.company;

import java.io.*;
import java.util.zip.ZipEntry;
import java.util.zip.ZipOutputStream;

public class P07_CreateZipArchive {
    public static void main(String[] args) {
        File words = new File("res/words.txt");
        StringBuilder wordsSb = new StringBuilder();
        File lines = new File("res/lines.txt");
        StringBuilder linesSb = new StringBuilder();
        File countchars = new File("res/count-chars.txt");
        StringBuilder countcharsSb = new StringBuilder();
        File zipDir = new File("res/zipDir.zip");

        try (BufferedReader br = new BufferedReader(
                new FileReader(words))) {
            String line = br.readLine();
            while (line!=null){
                wordsSb.append(line+"\n");
                line = br.readLine();
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }

        try (BufferedReader br = new BufferedReader(
                new FileReader(lines))) {
            String line = br.readLine();
            while (line!=null){
                linesSb.append(line+"\n");
                line = br.readLine();
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }

        try (BufferedReader br = new BufferedReader(
                new FileReader(countchars))) {
            String line = br.readLine();
            while (line!=null){
                countcharsSb.append(line+"\n");
                line = br.readLine();
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
        System.out.println(wordsSb);
        System.out.println(linesSb);
        System.out.println(countcharsSb);

        try (ZipOutputStream zos = new ZipOutputStream(
                new BufferedOutputStream(
                        new FileOutputStream(zipDir)))
        ){
            zos.putNextEntry(new ZipEntry(words.getName()).);
            zos.putNextEntry(new ZipEntry(lines.getName()));
            zos.putNextEntry(new ZipEntry(countchars.getName()));
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}