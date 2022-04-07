using System;
using Tuple_in_CSharp_7._0;

namespace TupleinCSharp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cat = Animal.OldAnimalTuple();
            Console.WriteLine($"My Name is {cat.Item1} Weight is {cat.Item2} height is {cat.Item3}");
            Console.WriteLine("****************************************************************");
            var dog = Animal.NewAnimal();
            Console.WriteLine($"My Name is {dog.name} Weight is {dog.weight} height is {dog.height}");

        }
    }
}
