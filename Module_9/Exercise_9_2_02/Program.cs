namespace Exercise_9_2_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                throw new ArgumentOutOfRangeException("Значение не попало в интервал значений");
            }
            catch(ArgumentOutOfRangeException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("...");
            }
        }
    }
}
