using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Human
    {
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        public Human(string firstName)
        {
            this.firstName = firstName;
           
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            
        }

        public Human(string firstName, string lastName, string eyeColor )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
           
        }


        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }
        public void IntroduceMyself()
        {
            if(firstName != null && lastName != null && eyeColor != null && age != 0)
            {
                Console.WriteLine("Hi, I am {0} {1} my eye color is {2} and I am {3} years old", firstName, lastName, eyeColor, age);
            }
            else if(firstName != null && lastName != null && eyeColor != null)
            {
                Console.WriteLine("Hi, I am {0} {1} my eye color is {2}", firstName, lastName, eyeColor);
            }
            else if (firstName != null && lastName != null)
            {
                Console.WriteLine("Hi, I am {0} {1}", firstName, lastName);
            }
            else if (firstName != null)
            {
                Console.WriteLine("Hi, I am {0}", firstName);
            }

        }


    }
}
