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

        public Human(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        //Consumed Either Poison or correct Food. If and else for correct food or not
        public void Eat(string food)
        {

        }
        //Exercise if and else for time. If too long then you die.
        public void Exercise(string Time) 
        { 
        
        }
    }
}
