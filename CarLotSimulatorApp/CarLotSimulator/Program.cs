using System;

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


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//
            var lot = new CarLot() { Name = "Mhoon Cars" };

            var popCar = new Car() { EngineNoise = "Vroom", IsDriveable = true, HonkNoise = "Beep", Make = "Chevy", Model = "Caprice", Year = 1975 };
            lot.CarList.Add(popCar);

            var rjCar = new Car();
            lot.CarList.Add(rjCar);

            var workCar = new Car("Mercedes","350",2020,"Move get out the way","zzzzz zzzzzz",true);
            lot.CarList.Add(workCar);
            
            rjCar.Make = "Toyota";
            rjCar.Model = "Corolla";
            rjCar.Year = 2005;
            rjCar.IsDriveable = true;
            rjCar.HonkNoise = "Baaa Baaa";
            rjCar.EngineNoise = "Tick tick tick";

            //Call each of the methods for each car
            foreach(Car mycar in lot.CarList)
            {
                mycar.MakeEngineNoise();
                mycar.MakeHonkNoise();
            }

            //Create a CarLot class

            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (Car vehichle in lot.CarList)
                Console.WriteLine($"Year:{vehichle.Year} , Make:{vehichle.Make} , Model: {vehichle.Model}");
            

        }
    }
}
