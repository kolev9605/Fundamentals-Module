using System;

class SquareRoot
{
    static void Main(string[] args)
    {
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Number must be positive.");
            }
            Console.WriteLine(Math.Sqrt(number));
        }
        catch (FormatException)
        {
            Console.Error.WriteLine("Invalid Number");
        }
        catch(ArgumentException)
        {
            Console.Error.WriteLine("Invalid Number");
        }
        catch(OverflowException)
        {
            Console.Error.WriteLine("Invalid Number");
        }
        catch(Exception)
        {
            Console.Error.WriteLine("Invalid Number");
        }
        finally
        {
            Console.WriteLine("Good Bye");
        }
    }
}