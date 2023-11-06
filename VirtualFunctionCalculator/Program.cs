using System;
namespace VirtualFunctionCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            AreaCalculator area=new AreaCalculator();
            area.Radius=4.1;
            Console.WriteLine(area.Area());
             area=new VolumeCalculator();
            area.Height=3.5;
            area.Radius=2.5;
            Console.WriteLine(area.Area());
        }
    }
}