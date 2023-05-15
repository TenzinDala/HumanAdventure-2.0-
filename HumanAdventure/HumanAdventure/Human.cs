using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanNamespace
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public string Pronoun { get; set; }

        public Human(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            if (gender == "male")
            {
                this.Pronoun = "he";
            }
            else
            {
                this.Pronoun = "she";
            }
        }

        //Consumed Either Poison or correct Food. If and else for correct food or not
        public bool Eat(string food)
        {
            food  = food.ToLower();
            if (food == "mushroom")
            {
                return true;
            }
            else {
                return false;
            }
        }
        //Exercise if and else for time. If too long then you die.
        public void Exercise(string Time) 
        { 
        
        }
        public void Fight(string Time)
        {

        }
        public bool Path(string path) { 
            path = path.ToLower();
            if (path == "second")
            {
                return true;
            }
            else {
                return false;
            }
        }

        public bool FightorFlight(string fightorflight) {
            if (fightorflight == "fight")
            {
                return false;
            }
            else {
                return true;
            }
        }
    }
}
