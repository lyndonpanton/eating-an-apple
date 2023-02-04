using Exercise6;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple(true, 3.2f);

            Console.WriteLine("My apple is organic: " + apple.Organic);
            Console.WriteLine("The remaining size of my apple is: " + apple.AmountLeft);
            Console.WriteLine();

            float bite = 0.3f;

            while (apple.AmountLeft > 0)
            {
                apple.TakeBite(bite);
                Console.WriteLine("Remaining size of my apple: " + apple.AmountLeft);
            }

            Console.WriteLine();
            Console.WriteLine("Apple is now finished");
        }
    }
}