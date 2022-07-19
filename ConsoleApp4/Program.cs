using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var minStack = new MinStack();

            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);

            Console.WriteLine("Smallest --> " + minStack.GetMin());

            Console.WriteLine(minStack.Top());
            Console.WriteLine("Smallest --> " + minStack.GetMin());
            Console.WriteLine(minStack.Pop());
            Console.WriteLine("Smallest --> " + minStack.GetMin());
            Console.WriteLine(minStack.Top());
            Console.WriteLine("Smallest --> " + minStack.GetMin());
            Console.WriteLine(minStack.Pop());
            Console.WriteLine("Smallest --> " + minStack.GetMin());
            Console.WriteLine(minStack.Pop());
            Console.WriteLine();

        }
    }
}
