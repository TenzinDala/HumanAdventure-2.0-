//Programmer - Tenzin Dala
//StudentID - 134244219


using HumanNamespace;

namespace HumanAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Tenzin = new Human("Tenzin", 22, "Male");
            Console.WriteLine($"Human's name is {Tenzin.Name}. He is {Tenzin.Gender} with the age of {Tenzin.Age}");
        }
    }
}