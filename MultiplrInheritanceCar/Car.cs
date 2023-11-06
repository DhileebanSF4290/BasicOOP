using System;

namespace MultiplrInheritanceCar
{
    public class Car
    {
        public string FuelType { get; set; }
        public int NumberOfSeats { get; set; }
        public string Colour { get; set; }
        public double TankCapacity { get; set; }
        public double NumberOfKmDriven { get; set; }
        
        public Car(string fuelType,int numberofSeats,string colour,double tankCapacity,double numberofKMDriven)
        {
            FuelType=fuelType;
            NumberOfSeats=numberofSeats;
            Colour=colour;
            TankCapacity=tankCapacity;
            NumberOfKmDriven=numberofKMDriven;
        }
        public double CalculateMileage(double kmsdriven,double tankcapacity)
        {
             return NumberOfKmDriven/TankCapacity;
        }
        
    }
}
