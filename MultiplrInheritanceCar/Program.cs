using System;
using MultiplrInheritanceCar;
namespace MultipleInheritanceCar
{
    class Program
    {
        public static void Main(string[] args)
        {
            ShiftDezire shift=new ShiftDezire("Hyundai","i10","diesel",4,"Black",20.5,400.5,"E101","HI1011");
           Console.WriteLine(shift.CalculateMileage(400.25,20.5));
            Eco eco=new Eco("EY101","Ford","diesel",4,"Green",18.5,200.50,"EC501","ECI1001");
            Console.WriteLine(eco.CalculateMileage(200.50,18.5));
            shift.ShowDetails();
            eco.ShowDetails();
        }
    }
}