using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var hummingbird = new Birds() { CanFly = true, Legs = 2, Habitat = "Nest"};

            hummingbird.PrintDetails();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var lizard = new Reptile() { ColdBlooded = true, Scales = true, Crawl = true};

            lizard.PrintDetails();

        }
    }
}
