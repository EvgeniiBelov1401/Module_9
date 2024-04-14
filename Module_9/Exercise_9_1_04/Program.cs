namespace Exercise_9_1_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception exception =new Exception("Ошибка");
            exception.HelpLink = "www.google.com";
        }
    }
}
