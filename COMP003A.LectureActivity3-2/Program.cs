﻿namespace COMP003A.LectureActivity3_2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Iterative Statements Demo!\n");
        
        //Prompt for a positive integer
        int num;
        Console.Write("Enter a positive integer to generate its multiplication table: ");
        num = int.Parse(Console.ReadLine());
        
        //generate multiplication table using a for loop
        Console.WriteLine($"Multiplication Table for {num}:");
        //loop to generate the multiplication table
        //the first statement initializes the loop variable i to 1
        //the second statement specifies the condition for the loop to continue
        //the third statement increments the loop variable i by 1
        for (int i = 1; i <= 10; i++)
        {   
            //display the multiplication table
            Console.WriteLine($"{i} * {num} = {i * num}");
        }

    }
}