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

        public int Strength;

        public Human(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Strength = 0;
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
        public bool Exercise(int Time) 
        {
            if (Time >= 15)
            {
                this.Strength += 100;
                return true
;            }
            else
            {
                this.Strength += 10;
                return false;
            }
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
                return true;
            }
            else {
                return false;
            }
        }

        public void ChangeGender()
        { 
            if(this.Gender == "male")
            {
                this.Gender = "female";
                this.Pronoun = "she";
            }
            else
            {
                this.Gender = "male";
                this.Pronoun = "he";
            }
        }
    }
}
