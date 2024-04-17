namespace Exercise_9_3_15
{
    internal class Program
    {
        delegate int RandomNumberDelegate();
        static void Main(string[] args)
        {
            RandomNumberDelegate randomNumberDelegate=() => new Random().Next(0, 100);
            
            int result = randomNumberDelegate.Invoke();
            Console.WriteLine(result);
        }
    }
}
