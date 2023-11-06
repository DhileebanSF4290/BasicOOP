using System;

namespace VirtualFunctionCalculator
{
    public class AreaCalculator
    {
        public double Radius { get; set; }
        public double Height { get; set; }
        
        
        
        public virtual double Area(){
            return 3.14*Radius*Radius;
        }
    }
}
