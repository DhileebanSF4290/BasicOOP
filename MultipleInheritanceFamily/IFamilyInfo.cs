using System;

namespace MultipleInheritanceFamily
{
    public interface IFamilyInfo : IShowData
    {
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int NumberOfSiblings { get; set; }
        
        void Showinfo();
        
    }
}
