//Programmer - Tenzin Dala
//StudentID - 134244219


using HumanNamespace;
using System.Xml.Linq;

namespace HumanAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name,Gender;
            int Age;
            Console.WriteLine("\tWelcome To Tenzin's Adventure\n");
            Console.WriteLine("Choose the Name of your Human!");
            name = Console.ReadLine();  
            Console.WriteLine("Choose the Age of your Human!");
            Age = Convert.ToInt32(Console.ReadLine());
            while (true) {
                Console.WriteLine("Choose the Gender of your Human!");
                Gender = Console.ReadLine();
                Gender = Gender.ToLower();
                if (Gender == "male" & Gender == "female")
                {
                    Console.WriteLine("Enter again");
                }
                else {
                    break;
                }
            }

            var human = new Human(name, Age, Gender);
            Console.WriteLine($"Human's name is {human.Name} with the Age of {human.Age} and the Gender is {human.Gender}");

            Console.WriteLine($"Once upon a time, there was a treasure hunter name {human.Name} who had a reputation for taking on the most dangerous of expeditions. {human.Name} had heard rumors of a priceless treasure hidden deep in the heart of the jungle, guarded by fierce predators and treachorous terrain. Despite the danger, {human.Name} couldn't resist the lure of the treasure and set out on his quest. \n");

            //Story Begins
            Console.WriteLine($"{human.Name} heads to the mysterious Mountain in search of the HIDDEN Treasure!!!");
            Console.ReadKey();
            Console.WriteLine($"{human.Pronoun} takes rest after a long walk and tries to scavenge for some food.");
            Console.ReadKey();
            Console.WriteLine($"{human.Name} comes across an area full of flora where {human.Pronoun} sees some berries and mushrooms.");
            Console.WriteLine("Choose between Mushroom and Berry");
            string food = Console.ReadLine();
            bool foodDeath = human.Eat(food);

            if (foodDeath)
            {
                Console.WriteLine($"{human.Name} ate loads of Mushrooms which was enough to satisfy the hunger.\n");
                Console.WriteLine($"As {human.Name} ventured deeper into the jungle, {human.Pronoun} encountered a two way path. One would lead up to a river that were full of crocodiles and the other one would lead up to a Cave with Booby Traps.\n");
                Console.WriteLine("Enter 'first' or 'second'");
                string path = Console.ReadLine();
                bool pathDeath = human.Path(path);

                if (pathDeath)
                {
                    Console.WriteLine($"As {human.Name} ventured deep into the cave, {human.Pronoun} encountered a series of booby traps, cunningly designed to keep out would-be thieves. But {human.Name} was a seasoned treasure hunter, and {human.Pronoun} managed to outsmart each trap.\n");
                    
                    Console.WriteLine($"Finally, {human.Name} arrived at a massive chamber filled with glittering jewels and golden artifcats. But before {human.Pronoun} could claim his prize, he heard a low growl behind him. Turning around, {human.Name} was face to face with a massive Tiger, its eyes glowing in the dim light.");
                    Console.WriteLine("Choose between 'flight' or 'fight'");
                    string FightorFlight = Console.ReadLine();
                    FightorFlight = FightorFlight.ToLower();
                    bool deathFightorFlight = human.FightorFlight(FightorFlight);
                    if (deathFightorFlight)
                    {
                        Console.WriteLine("Found the Treasure.\n");
                    }
                    else {
                        Console.WriteLine("Died!!!");
                    }
                    
                }
                else {
                    Console.WriteLine($"{human.Name} tries to walk on the river shore to avoid the sharks but unfortunately Slips and Falls in the river just to be consumed by the vicious Crocodiles.\n");
                }
            }
            else {
                Console.WriteLine($"{human.Name} realizes that the berries was posinous and hence suffocates which leads to painful death.");
            }
        }
    }
}