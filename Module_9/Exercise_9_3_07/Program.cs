namespace Exercise_9_3_07
{
    internal class Program
    {
        //delegate void ShowMessageDelagate();
        //delegate int SumDelegate(int a,int b,int c);
        //delegate bool CheckLengthDelegate(string row);

        static void ShowMessage()
        {
            Console.WriteLine("Hello, world!!!");
        }
        static int Sum(int a,int b,int c)
        {
            return a + b + c;
        }
        static bool CheckLength(string row)
        {
            if (row.Length>3)return true;
            else return false;
        }
        static void Main(string[] args)
        {
            Action showMessageDelagate=ShowMessage;
            showMessageDelagate.Invoke();

            Func<int,int,int,int> sumDelegate=Sum;
            int result=sumDelegate.Invoke(10,20,3);
            Console.WriteLine(result);

            Predicate<string> checkLengthDelegate=CheckLength;
            bool status = checkLengthDelegate.Invoke("SkillFactory");
            Console.WriteLine(status);
        }
    }
}
