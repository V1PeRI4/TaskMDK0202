using hardTask;
using System;
using System.Collections.Generic;
using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите номер задания: ");
        int count = int.Parse(Console.ReadLine());

        switch (count)
        {
            case 1:
                int denominator = 20;
                int countFollowingTram = 40;
                int countReverseTram = 60;
                int speed = 3;

                countFollowingTram /= denominator;
                countReverseTram /= denominator;
                int sum = (countFollowingTram + countReverseTram) * speed;

                Console.WriteLine(sum);
                break;

            case 2:
                SecondTask.Second();
                break;

            default:
                break;
        }


        Console.ReadLine();

    }
}
