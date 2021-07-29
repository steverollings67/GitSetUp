using System;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogs dog = new Dogs();

            dog.Age = 3;
            dog.Name = "Spot";
            dog.Breed = "Lab";
            dog.Greeting();

            Dogs dog2 = new Dogs();
            dog2.Age = 4;
            dog2.Name = "Cindy";
            dog2.Breed = "Chihuahua";
            dog2.Greeting();



        }
    }
}
