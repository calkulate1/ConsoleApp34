using PairClass;
using System;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            Pair<string, int> nameAgePair = new Pair<string, int>("Alice", 30);
            Console.WriteLine($"name: {nameAgePair.Key}, age: {nameAgePair.Value}");
        }
    }
}
