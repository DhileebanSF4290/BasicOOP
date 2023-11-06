using System;

namespace VirtualFunctionCalculator
{
    public class VolumeCalculator : AreaCalculator
    {
       // public double Height { get; set; }
        
        
        public override double Area()
        {
            return 3.14*Radius*Height;
        }

    }
}
