﻿namespace Exercise_9_3_05
{
    internal class Program
    {
        delegate void ShowDelegate(int a,int b);

        static void Subtraction(int a,int b)
        {
            Console.WriteLine($"{a}-{b}={a-b}");
        }
        static void Sum(int a, int b)
        {
            Console.WriteLine($"{a}+{b}={a + b}");
        }
        static void Main(string[] args)
        {
            ShowDelegate showDelegate = Subtraction;
            showDelegate += Sum;
            showDelegate -= Sum;
            showDelegate.Invoke(20, 8);
        }
    }
}
