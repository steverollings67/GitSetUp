using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    public class Dogs
    {
        public int Age;
        public string Name;
        public string Breed;
        public bool HasOwner;

        public void Greeting()
        {
            Console.WriteLine("My dog's name is " + Name + " so don't where it out.\nMy dog's age is " + Age + ".");
            Console.WriteLine("The breed of my dog is " + Breed + ".");
        }
    }
}
