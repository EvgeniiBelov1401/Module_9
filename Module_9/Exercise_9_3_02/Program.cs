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

            int result = subtractionDelegate.Invoke(50,20);
            Console.WriteLine(result);  
            
        }
    }
}
