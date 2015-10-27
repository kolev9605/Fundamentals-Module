package com.company;

import java.io.*;

public class P03_CountCharacterTypes {
    public static void main(String[] args) {
        File file = new File("res/words.txt");
        File outputFile = new File("res/count-chars.txt");
        int vowelCount = 0;
        int consonantsCount = 0;
        int punctuationMarkCount = 0;
        try (BufferedReader bfr = new BufferedReader(
                                    new FileReader(file));
             BufferedWriter bfw = new BufferedWriter(
                                    new FileWriter(outputFile))){
            int currChar = bfr.read();
            while (currChar!=-1){
                if ((char)currChar==' '){
                    currChar = bfr.read();
                    continue;
                }
                if (isVowel(currChar)){
                    //vowel
                    vowelCount++;
                }
                else if (isPunctuationMark(currChar)){
                    //mark
                    punctuationMarkCount++;
                }
                else{
                    //not vowel
                    consonantsCount++;
                }
                currChar = bfr.read();
            }
            bfw.write("Vowels: "+vowelCount+"\n");
            bfw.write("Consonants: "+consonantsCount+"\n");
            bfw.write("Punctuation: "+punctuationMarkCount+"\n");
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
    private static boolean isVowel (int currChar) {
        //a, e, i, o, u
        if ((char)currChar=='a'||
                (char)currChar=='e'||
                (char)currChar=='i'||
                (char)currChar=='o'||
                (char)currChar=='u'){
            return true;
        }
        else {
            return false;
        }
    }
    private static boolean isPunctuationMark (int currChar){
        //!,.?
        if ((char)currChar=='!'||
                (char)currChar==','||
                (char)currChar=='.'||
                (char)currChar=='?'){
            return true;
        }
        else {
            return false;
        }
    }
}
