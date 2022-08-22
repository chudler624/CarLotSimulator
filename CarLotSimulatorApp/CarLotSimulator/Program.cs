using System;
using CarLotSimulator;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            Car firstCar = new Car();

            firstCar.Year = 2022;
            firstCar.Model = "";

            CarLot.numberOfCars++;
            Console.WriteLine(CarLot.numberOfCars);

            //public string Make = "Dodge",
            //public string Model = "Hell Cat",
            //public string EngineNoise = "VROOM",
            //public string HonkNoise = "Beep Beep",
            //bool IsDriveable = true;

            Car secondCar = new Car() { Year = 2021, Make = "Ford", Model = "Mustang", EngineNoise = "Zoom", HonkNoise = "BEEP", IsDriveable = true };  
            CarLot.numberOfCars++;
            Console.WriteLine(CarLot.numberOfCars);


            Car thirdCar = new Car();


            thirdCar.Year = 2020;
            thirdCar.Make = "Chevy";
            thirdCar.Model = "Camaro";
            thirdCar.EngineNoise = "ZoomZoom";
            thirdCar.HonkNoise = "MeepMeep";
            thirdCar.IsDriveable = true;

            CarLot.numberOfCars++;
            Console.WriteLine(CarLot.numberOfCars);


        }



    }

}







//Now that the Car class is created we can instanciate 3 new cars
//Set the properties for each of the cars
//Call each of the methods for each car

//*************BONUS*************//

// Set the properties utilizing the 3 different ways we learned about, one way for each car

//*************BONUS X 2*************//

//Create a CarLot class
//It should have at least one property: a List of cars
//Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
//At the end iterate through the list printing each of car's Year, Make, and Model to the console

