using System.IO;

namespace MaximumNumberUsingGenerics
{
    public class Program
    {
        static void Main(string[] args)
        {
            MaximumNumber maximum = new MaximumNumber();

            Console.WriteLine("Maximum String is : " + maximum.MaxNumber<int>(30, 20, 10));
            Console.WriteLine("Maximum String is : " + maximum.MaxNumber<float>(30, 20, 10));
            Console.WriteLine("Maximum String is : " + maximum.MaxNumber<string>("44", "30", "10"));
        }
    }
}