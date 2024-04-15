﻿namespace Exercise_9_3_12
{
    internal class Program
    {
        delegate void ShowMessageDelegate(string _message);
        //static void ShowMessage(string _message)
        //{
        //    Console.WriteLine(_message);
        //}
        static void Main(string[] args)
        {
            string Message = "Hello World!";
            ShowMessageDelegate showMessageDelegate = delegate (string _message)
            {
                Console.WriteLine(_message);
            };
            showMessageDelegate.Invoke(Message);
        }
    }
}
