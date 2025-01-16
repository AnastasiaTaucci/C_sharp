using System;

namespace StaticDogHW
{
    class Program
    {
        static void Main(string[] args)
        {
            // will have 3 Dogs
            Dog[] allDogs = new Dog[3];

            allDogs[0] = new Dog(20f, 10f, "Fido");
            allDogs[1] = new Dog(40f, 20f, "Percy");
            allDogs[2] = new Dog(70f, 30f, "Snoopy");

            // comment out the next 3 lines until you have written the Dog class and the code runs ok
            // then put these 3 lines back in after you write your static class
            Console.WriteLine("{0} is healthy: {1}", allDogs[0].Name, HealthCheck.IsHealthy(allDogs[0]));
            Console.WriteLine("{0} is healthy: {1}", allDogs[1].Name, HealthCheck.IsHealthy(allDogs[1]));
            Console.WriteLine("{0} is healthy: {1}", allDogs[2].Name, HealthCheck.IsHealthy(allDogs[2]));

            Console.ReadLine();
        }
    }  //  end of class Program

    //========================================================

    // define a non-static class Dog
    // give it 3 properties
    // float Weight 
    // float Height 
    // string Name
    // write a constructor that takes in a weight, height and name and sets those 3 properties
    // get the first part of the Main method to work.

    //========================================================


    // write a static class named  HealthCheck
    // indside, write a static method called IsHealthy that takes in a Dog object
    // divide the dog's weight by its height
    // if the answer is greater than 2, return false, otherwise, return true

    //========================================================

}
