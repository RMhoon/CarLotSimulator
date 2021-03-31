using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class CarLot
    {
        //Create a CarLot class
        //It should have at least one property: a List of cars
        private List<Car> cars;

        public static int numOfCars;

        public CarLot()
        {
            cars = new List<Car>();
        }

        public string Name { get; set; }

        public List<Car> CarList
        {
            get
            { return cars; }
        }
    }
}
