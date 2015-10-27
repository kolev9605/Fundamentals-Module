using System;

class FourDigitNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int firstDigit = number % 10;
        int secondDigit= number / 10 % 10;
        int thirdDigit = number / 100 % 10;
        int fourthDigit = number / 1000;

        int sumOfDigits = firstDigit + secondDigit + thirdDigit + fourthDigit;
        int reversedNumber = firstDigit * 1000 + secondDigit * 100 + thirdDigit * 10 + fourthDigit;
        int lastDigitInFront = firstDigit * 1000 + secondDigit + thirdDigit * 10 + fourthDigit * 100;
        int swapSecondAndThird = firstDigit + secondDigit * 100 + thirdDigit * 10 + fourthDigit * 1000;

        Console.WriteLine(sumOfDigits);
        Console.WriteLine(reversedNumber);
        Console.WriteLine(lastDigitInFront);
        Console.WriteLine(swapSecondAndThird);

    }
}

