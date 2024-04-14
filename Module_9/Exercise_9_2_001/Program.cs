namespace Exercise_9_2_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Блок try отработал");
                throw new FileNotFoundException();
            }
            catch (Exception ex) when(ex is ArgumentNullException)
            {

                Console.WriteLine("Аргумент пустой");
                
            }
            catch (Exception ex) when (ex is FileNotFoundException)
            {

                Console.WriteLine("Файл не найден");

            }
            finally
            {
                Console.WriteLine("Блок finally отработал");
            }
        }
    }
}
