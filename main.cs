using System;

class Program {
  public static void Main (string[] args) {
    

    Console.WriteLine("Enter number");
    int number;
    number = Convert.ToInt32(Console.ReadLine());
    int divisors = 0;

    for (int i = 1; i<= number; i++)
    {
    if (number % i == 0) 
    Console.WriteLine("The number is prime");

    if (number % i != 0)
    Console.WriteLine("The number is not prime");
    }
  }
}