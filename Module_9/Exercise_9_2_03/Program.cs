namespace Exercise_9_2_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new RankException();
            }
            catch (RankException ex)
            {
                Console.WriteLine(ex.GetType());
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
