using System;

namespace MaximumNumberUsingGenerics
{
    public class Program
    {
        static void Main(string[] args)
        {
            MaximumNumber<int> maximumInt = new MaximumNumber<int>(30, 20, 10, 40);
            Console.WriteLine("Maximum Number is : " + maximumInt.MaxMethod());
            MaximumNumber<float> maximumFloat = new MaximumNumber<float>(10, 40, 30, 20);
            Console.WriteLine("Maximum Number is : " + maximumFloat.MaxMethod());
            MaximumNumber<string> maximumString = new MaximumNumber<string>("20", "30", "40", "10");
            Console.WriteLine("Maximum Number is : " + maximumString.MaxMethod());

            int[] arr = { 112, 344, 432, 555, 678 };
            MaximumNumberUsingMaxMethod<int> maxMethod = new MaximumNumberUsingMaxMethod<int>(arr);
            maxMethod.PrintMaxValue();
        }
    }
}