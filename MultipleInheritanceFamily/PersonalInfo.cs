using System;

namespace MultipleInheritanceFamily
{
    public  enum Gender{Default,male,female};
    public enum Status{Married,Single};
    public class PersonalInfo : IShowData
    {
        public string Name { get; set; }
        public Gender Mygender { get; set; }
         public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public Status MyStatus { get; set; }
        
        public PersonalInfo(string name,Gender gender,DateTime dob,string phone,string mobile,Status status)
        {
            Name=name;
            Mygender=gender;
            DOB=dob;
            Phone=phone;
            Mobile=mobile;
            MyStatus=status;
        }
        
        public void ShowInfo()
        {
            Console.WriteLine($"Your Name : {Name}\nYour Gender : {Mygender}\nYour Date Of Birth : {DOB}\n Your Phone NUmber : {Phone}\nYour MObile Number : {Mobile}\nYour Marrital Status : {MyStatus}");
        }
        
        
    }
}
