using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple_in_CSharp_7._0
{
    internal class Animal
    {
        public static Tuple<string, double, double> OldAnimalTuple()
        {
            string name = "Cat";
            double weight = 10.5;
            double height = 5.2;
            Tuple<string, double, double> activity = new Tuple<string, double, double>(name, weight, height);
            return activity;
        }
        public static (string name, double weight, double height) NewAnimal()
        {
            string name = "Dog";
            double weight = 15;
            double height = 10;
            return (name, weight, height);
        }
    }
}
