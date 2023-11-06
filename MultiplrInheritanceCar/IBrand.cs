using System;

namespace MultiplrInheritanceCar
{
    public interface IBrand
    {
        public string BrandName { get; set; }
        
        public string ModelName { get; set; }
        void ShowDetails();
        
    }
}
