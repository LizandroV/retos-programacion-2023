﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("FIZZ BUZZ");


for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i % 15 == 0 ? "fizzbuzz" : i % 3 == 0 ? "fizz" : i % 5 == 0 ? "buzz" : i);
}