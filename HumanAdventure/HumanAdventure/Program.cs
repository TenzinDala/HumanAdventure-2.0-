//Programmer - Tenzin Dala
//StudentID - 134244219


using HumanNamespace;
using System.Data;
using System.Xml.Linq;

namespace HumanAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, Gender;
            int Age;
            Console.WriteLine("\t\tWelcome To Tenzin's Adventure\n");
            Console.WriteLine("\tChoose the Name of your human!");
            name = Console.ReadLine();
            Console.WriteLine("\tChoose the Age of your human!");
            Age = Convert.ToInt32(Console.ReadLine());
            while (true) {
                Console.WriteLine("\tChoose the Gender of your human! ('male' or 'female')");
                Gender = Console.ReadLine();
                Gender = Gender.ToLower();
                if (Gender == "male" & Gender == "female")
                {
                    Console.WriteLine("\tEnter again");
                }
                else {
                    break;
                }
            }

            var human = new Human(name, Age, Gender);
            Console.WriteLine($"\n\tHuman's name is {human.Name} with the Age of {human.Age} and the Gender is {human.Gender}\n");
            Console.WriteLine($"\tOnce upon a time, there was a treasure hunter name {human.Name} who had a reputation for taking on the most dangerous of expeditions. \n\n");
            Console.ReadKey();
            Console.WriteLine($"\t{human.Pronoun} had heard rumors of a priceless treasure hidden deep in the heart of the jungle, guarded by fierce predators and treachorous terrain. ");
            Console.ReadKey();
            Console.WriteLine($"\n\tDespite the danger, {human.Name} couldn't resist the lure of the treasure and set out on his quest.\n");
            //Story Begins
            Console.WriteLine($"\t{human.Name} heads to the mysterious Mountain in search of the HIDDEN Treasure!!!\n");
            Console.ReadKey();
            Console.WriteLine($"\t{human.Pronoun} takes rest after a long walk and tries to scavenge for some food.\n");
            Console.ReadKey();
            Console.WriteLine($"\t{human.Name} comes across an area full of flora where {human.Pronoun} sees some berries and mushrooms.\n");
            Console.WriteLine("\tChoose between Mushroom and Berry");
            string food = Console.ReadLine();
            bool foodDeath = human.Eat(food);

            if (foodDeath)
            {
                if (human.Gender == "male")
                {
                    Console.WriteLine($"{human.Name} must change gender to female for cooking the Mushrooms proficiently.\n");
                    Console.ReadKey();
                    human.ChangeGender();
                    Console.WriteLine($"{human.Name}'s Gender has been changed!!!\n");
                    Console.ReadKey();
                }
                Console.WriteLine($"\t{human.Name} ate loads of Mushrooms which was enough to satisfy the hunger.\n");
                Console.WriteLine($"\tAs {human.Name} ventured deeper into the jungle, {human.Pronoun} encountered a two way path. One would lead up to a river that were full of crocodiles and the other one would lead up to a Cave with Booby Traps.\n");
                Console.WriteLine("\tEnter 'first' or 'second'");
                string path = Console.ReadLine();
                bool pathDeath = human.Path(path);

                if (pathDeath)
                {
                    Console.WriteLine($"\tAs {human.Name} ventured deep into the cave, {human.Pronoun} encountered a series of booby traps, cunningly designed to keep out would-be thieves. But {human.Name} was a seasoned treasure hunter, and {human.Pronoun} managed to outsmart each trap.\n");
                    Console.ReadKey();
                    
                    Console.WriteLine($"\tFinally, {human.Name} arrives at a massive chamber filled with glittering jewels and golden artifacts. But before {human.Pronoun} could claim his prize, he heard a low growl behind him. Turning around, {human.Name} was face to face with a massive Tiger, its eyes glowing in the dim light.\n");
                    Console.WriteLine("\tChoose between 'flight' or 'fight'");
                    string FightorFlight = Console.ReadLine();
                    FightorFlight = FightorFlight.ToLower();
                    bool deathFightorFlight = human.FightorFlight(FightorFlight);
                    if (deathFightorFlight)
                    {
                        if(human.Gender == "female")
                        {
                            Console.WriteLine($"{human.Name} must change the Gender to male for fighty this creature.\n");
                            Console.ReadKey();
                            human.ChangeGender();
                            Console.WriteLine($"{human.Name}'s Gender has been changed!!!\n");
                            Console.ReadKey();
                        }
                        Console.WriteLine($"\t{human.Pronoun} tries to stab the Tiger as the mighty beast lunges over!\n");
                        Console.ReadKey();
                        Console.WriteLine($"\t{human.Name} gets fatally wounded. {human.Pronoun} has no choice but to exercise to gain more strength!!! \n");
                        Console.WriteLine("\tEnter the number of minutes. Example '5' or '20'");
                        int time = Convert.ToInt32(Console.ReadLine());
                        bool deathExercise = human.Exercise(time);
                        if (deathExercise)
                        {
                            Console.WriteLine($"\t{human.Name} strength increased to {human.Strength} points.");
                            Console.WriteLine($"\tThis was enough power to split the Tiger with his bare hands.\n\n");

                        }
                        else {

                            Console.WriteLine($"\t{human.Name} strength increased to {human.Strength} points.");
                            Console.WriteLine($"\t{human.Pronoun} tries to fight the tiger but the strength was not enough.\n");
                            Console.WriteLine($"\tTiger kills {human.Name} painfully and satisfies his hunger.\n");

                        }

                    }
                    else {
                        Console.WriteLine("\tDied!!!");
                    }
                    
                }
                else {
                    Console.WriteLine($"\t{human.Name} tries to walk on the river shore to avoid the crocs but unfortunately Slips and Falls in the river just to be consumed by the vicious Crocodiles.\n");
                }
            }
            else {
                Console.WriteLine($"\t{human.Name} realizes that the berries was posinous and hence suffocates which leads to painful death.");
            }
        }
    }
}