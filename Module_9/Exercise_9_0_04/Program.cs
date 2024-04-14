namespace Exercise_9_0_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"D:\Programming\Skillfactory\C#_projects\Module_9\Module_9\Exercise_9_0_04\Новая папка");
            if (!dirInfo.Exists )
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory("Внутренняя папка");
        }
    }
}
