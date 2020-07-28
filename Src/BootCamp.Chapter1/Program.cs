using System;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            var test =  new[] {0, 1};

            Console.Write("Array before: ");

            foreach(var number in test)
            {
                Console.Write(number);
            }

            Console.Write("\nArray after: ");
            test = ArrayOperations.RemoveAt(test, 2);

            foreach (var number in test)
            {
                Console.Write(number);
            }
        }
    }
}
