using System;

namespace MultiplrInheritanceCar
{
    public class Eco : Car,IBrand
    {
        public string ModelName { get; set; }
        public string BrandName { get; set; }
        private static int s_makingID=100;
        public string MakingID { get; }
        public string EngineNumber { get; set; }
        
        public string ChasisNumber { get; set; }
        
        public Eco(string modelName,string brandName, string fuelType,int numberofSeats,string colour,double tankCapacity,double numberofKMDriven,string engineNUmber,string chasisNumber) : base(fuelType,numberofSeats,colour,tankCapacity,numberofKMDriven)
        {
            s_makingID++;
            MakingID="ECO"+s_makingID;
            ModelName=modelName;
            BrandName=brandName;
            EngineNumber=engineNUmber;
            ChasisNumber=chasisNumber;
        }
         public void ShowDetails()
        {
            Console.WriteLine($"Your Car Model Name :{ModelName}\nYour Car's Brand Name : {BrandName}\nYour Car's FuelType : {FuelType}\nYour Car's Number of Seats : {NumberOfSeats}\nYour Car's Colour : {Colour}\nYour Car's Tank Capacity : {TankCapacity}\nYour Car's Tank Capacity : {TankCapacity}\nYour had Driven : {NumberOfKmDriven}\nYour Car's Engine NUmber : {EngineNumber}\nYour Exclusive Identification Number : {ChasisNumber}");
        }
        
        
    }
}
