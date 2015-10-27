package com.company;

import java.io.*;

public class P06_SaveCustomObject {
    public static void main(String[] args) {
        Course firstStudent = new Course();
        firstStudent.name = "Ivan";
        firstStudent.studentsCount = 2;

        try (ObjectOutputStream oos = new ObjectOutputStream(
                new BufferedOutputStream(
                        new FileOutputStream("res/course.save.hj")))
        ) {
            oos.writeObject(firstStudent);
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
