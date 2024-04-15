namespace Exercise_9_3_006
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
            ShowDelegate showDelegate1 = Subtraction;
            ShowDelegate showDelegate2 = Sum;
            ShowDelegate showDelegate3=showDelegate1 + showDelegate2;
            showDelegate3.Invoke(30,6);
        }
    }
}
