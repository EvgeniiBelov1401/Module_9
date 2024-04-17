namespace Exercise_9_3_13
{
    internal class Program
    {
        delegate int RandomNumberDelegate();
        //static int RandomNumber()
        //{
        //    return new Random().Next(0, 100);
        //}
        static void Main(string[] args)
        {
            RandomNumberDelegate randomNumberDelegate = delegate
            {
                return new Random().Next(0, 100);
            };
            int result = randomNumberDelegate.Invoke();
            Console.WriteLine(result);
        }
    }
}
