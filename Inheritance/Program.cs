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
             * Creatively display the class member values 
             */

            Bird myBird = new Bird();
            myBird.canFly = true;
            myBird.hasWings = true;
            myBird.wingColor = "red";
            myBird.beakAmount = 1;
            Console.WriteLine($"My bird has these features:  ");
            Console.WriteLine($"Has wings: {myBird.hasWings}");
            Console.WriteLine($"Can fly:   {myBird.canFly}"); 
            Console.WriteLine($"Has how many beaks? {myBird.beakAmount}");
            Console.WriteLine($"Wing color:  {myBird.wingColor}");
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile myReptile = new Reptile();
            myReptile.canSwim = true;
            myReptile.hasScales = true;
            myReptile.isColdBlooded = true;
            myReptile.hasTail = true;
            Console.WriteLine($"My reptile has all of these features:  ");
            Console.WriteLine($"Can Swim: {myReptile.canSwim}");
            Console.WriteLine($"Has scales: {myReptile.hasScales}");
            Console.WriteLine($"Is cold blooded: {myReptile.isColdBlooded} ");
            Console.WriteLine($"Has a tail: {myReptile.hasTail}!");
        }
    }
}
