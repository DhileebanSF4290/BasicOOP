using System;

namespace MultipleInheritanceFamily
{
    public class RegisterPerson :PersonalInfo,IFamilyInfo, IShowData
    {
        public string FatherName { get; set; }
        
        public string MotherName { get; set; }
        
        public string HouseAddress { get; set; }
        public int NumberOfSiblings { get; set; }
        
        public static int s_registrationNo=100;
        public string Registration { get;  }
        public DateTime DateOfRegistration { get; set; }
        
       // public int NumberOfSibilings { get; set; }
         public RegisterPerson(string name,Gender gender,DateTime dob,string phone,string mobile,Status status,string fatherName,string motherName,string houseAddress,int noOfSiblings,DateTime dateofregistration) : base(name,gender,dob,phone,mobile,status)
         {
            s_registrationNo++;
            Registration="RN"+s_registrationNo;
                 FatherName=fatherName;
                 MotherName=motherName;
                 HouseAddress=houseAddress;
                 NumberOfSiblings=noOfSiblings;
                 DateOfRegistration=dateofregistration;
         } 
         public void  Showinfo()
         {
                        Console.WriteLine($"Your Name : {Name}\nYour Gender : {Mygender}\nYour Date Of Birth : {DOB}\n Your Phone NUmber : {Phone}\nYour MObile Number : {Mobile}\nYour Marrital Status : {MyStatus}\nYour Registration ID : {Registration}\nYour Father Name : {FatherName}\nYour Mother Name : {MotherName}\nYour House Address : {HouseAddress}\nNumber Of Siblings You Have : {NumberOfSiblings}\nDate of Registration : {DateOfRegistration}");

         }
        
    }
}
