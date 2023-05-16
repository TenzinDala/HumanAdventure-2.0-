using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanNamespace
{
    public class Human
    {
        //The Access modifier for the first 4 attributes will be public because they need to be output to the console
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public string Pronoun { get; set; }

        //User do not need to know the strength points
        private int Strength;

        //Constructor
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

        //The Access modifier needs to be public because this method is meant to be accessible from any class and when the class is used
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
        //The Access modifier needs to be public because this method is meant to be accessible from any class and when the class is used
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

        //The Access modifier needs to be public because this method is meant to be accessible from any class and when the class is used
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


        //The Access modifier needs to be public because this method is meant to be accessible from any class and when the class is used
        public bool FightorFlight(string fightorflight) {
            if (fightorflight == "fight")
            {
                return true;
            }
            else {
                return false;
            }
        }

        //The Access modifier needs to be public because this method is meant to be accessible from any class and when the class is used
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
