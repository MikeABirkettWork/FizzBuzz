using System;

public class FizzBuzzKata : IFizzBuzzKata
{
    public static void Main(string[] args)
    {
        IFizzBuzzKata obj = new FizzBuzzKata();

        int i = 0;
        int j = 1000;

        while (i < j)
        {
            Console.WriteLine(obj.Answer(i));

            i++;
        }

        Console.ReadLine();
    }

    public string Answer(int i)
    {
        if (i % 3 == 0 && i % 5 == 0)
            return "FizzBuzz";
        else if (i % 3 == 0)
            return "Fizz";
        else if (i % 5 == 0)
            return "Buzz";
        else
            return i.ToString();
    }
}

public interface IFizzBuzzKata
{
    /// <summary>
    /// Give an answer to the current game
    /// </summary>
    /// <param name="number">current number in the game sequence</param>
    /// <returns>appropriate answer to the current number</returns>
    string Answer(int number);
}
