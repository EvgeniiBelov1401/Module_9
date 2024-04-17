using Exercise_9_4_02.Models;

namespace Exercise_9_4_02
{
    internal class Program
    {
        delegate Car GetCarInfo();
        static Car CarInfo()
        {
            return new Car();
        }
        static Lexus LexusInfo()
        {
            return new Lexus();
        }
        static void Main(string[] args)
        {
            GetCarInfo getCarInfo1 = CarInfo;
            GetCarInfo getCarInfo2 = LexusInfo;
            
        }
    }
}
