package com.company;


import java.io.*;
import java.util.ArrayList;
import java.util.DoubleSummaryStatistics;

public class P05_SaveArrayList{
    public static void main(String[] args) {
        ArrayList<Double> list = new ArrayList<>();
        list.add(2.5);
        list.add(23.63);
        list.add(12.9);
        try (
            ObjectOutputStream oos = new ObjectOutputStream(
                                    new BufferedOutputStream(
                                    new FileOutputStream("res/doubles.list")))
        ){
            oos.writeObject(list);
        } catch (IOException e) {
            e.printStackTrace();
        }
        try (
            ObjectInputStream ois = new ObjectInputStream(
                                    new BufferedInputStream(
                                            new FileInputStream("res/doubles.list")))
        ){
            ArrayList<Double> listCopy = (ArrayList<Double>) ois.readObject();
            System.out.println(listCopy);
        } catch (IOException e) {
            e.printStackTrace();
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
        }
    }

}