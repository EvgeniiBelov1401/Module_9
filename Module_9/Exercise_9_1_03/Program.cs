namespace Exercise_9_1_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception();

            exception.Data.Add("Дата ошибки",DateTime.Now);
        }
    }
}
