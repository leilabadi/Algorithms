﻿// See https://aka.ms/new-console-template for more information
using Algorithms.Fibonacci;

Fibonacci fib;

Console.WriteLine($"n   Fibonacci Counter");
Console.WriteLine();

fib = new FibonacciIterative();
Console.WriteLine();
Console.WriteLine("Iterative");
Console.WriteLine("---------------------------");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{i}\t{fib.Generate(i)}\t{fib.Counter}");
}

fib = new FibonacciRecursive();
Console.WriteLine();
Console.WriteLine("Recursive");
Console.WriteLine("---------------------------");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{i}\t{fib.Generate(i)}\t{fib.Counter}");
}

fib = new FibonacciCachedRecursive();
Console.WriteLine();
Console.WriteLine("Cached Recursive");
Console.WriteLine("---------------------------");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{i}\t{fib.Generate(i)}\t{fib.Counter}");
}