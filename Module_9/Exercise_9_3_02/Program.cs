using System.Security.Cryptography.X509Certificates;

namespace Exercise_9_3_02
{
    internal class Program
    {
        delegate int SubtractionDelegate(int a,int b);
        static int Subtraction(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            SubtractionDelegate subtractionDelegate = Subtraction;

            int result1 = subtractionDelegate.Invoke(50,20);
            int result2 =subtractionDelegate(40,30);
            Console.WriteLine(result1+"\n"+result2);  
            
        }
    }
}
