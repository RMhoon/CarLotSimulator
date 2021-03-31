using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public Car()
        {
            CarLot.numOfCars++;
        }

        public Car(string make, string model , int year , string honknoise, string enginenoise, bool isdriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = enginenoise;
            HonkNoise = honknoise;
            IsDriveable = isdriveable;
            CarLot.numOfCars++;
        }

        public void MakeEngineNoise() 
        {
            Console.WriteLine($"{Make} engine goes {EngineNoise}");
        }
        
        public void MakeHonkNoise()
        {
            Console.WriteLine($"{Make} horn goes: {HonkNoise}");
        }
    }
}
