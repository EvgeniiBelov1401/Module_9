namespace Exercise_9_3_14
{
    internal class Program
    {
        delegate void ShowMessageDelegate(string _message);
        static void Main(string[] args)
        {
            ShowMessageDelegate showMessageDelegate = message=> Console.WriteLine(message);        
            showMessageDelegate.Invoke("Hello World!");
        }
    }
}
