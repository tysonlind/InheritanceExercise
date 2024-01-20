using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             *  
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Bird toucan = new Bird();
            toucan.Age = 10;
            toucan.Weight = 20;
            toucan.WingSpan = 35;
            toucan.CanFly = true;
            toucan.NumOfLegs = 2;

            Reptile lizard = new Reptile();
            lizard.ColdBlooded = false;
            lizard.NumOfLegs = 4;

            Console.WriteLine($"check out my pet collection, my lizard has {lizard.NumOfLegs} legs and my pet toucan has a wing span of  {toucan.WingSpan} cm!");
        }
    }
}
